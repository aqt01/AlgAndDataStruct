using System;

using System.Collections.Generic;
using System.IO;

namespace Trie
{
    class MainClass
    {

        public static void Main(string[] args)
        {

            Trie trie = new Trie();
			Game game = new Game();
            int szMatrix; // tamanio de la matrix
			char mand; // letra mandatoria
			trie.LoadDict(); // Se carga el diccionario con todas las palabras
														
			Console.WriteLine("Initial Testings! ...");
            Console.WriteLine("ABANDONER : " + trie.Find("ABANDONER")); // Debe retornar 1999
            Console.WriteLine("ABDOH : " + trie.Find("ABDOH"));	 // Debe retornar 1999	
            Console.WriteLine("ALZHEIMER : " + trie.Find("ALZHEIMER"));  // Debe retornar 1929       
			Console.WriteLine("THAT : " + trie.Find("THAT"));  // Debe retornar 1930
			Console.WriteLine("A : " + trie.Find("A"));  // Debe retornar 1930
			Console.WriteLine("WARY : " + trie.Find("WARY"));  // Debe retornar 1930
			Console.WriteLine("OF : " + trie.Find("OF"));  // Debe retornar 1930
			
			Console.WriteLine();
			
            Console.WriteLine("Defina el Tamanio de la matriz: "); 
            szMatrix = (int.Parse(Console.ReadLine()));	// se asigna el tamanio a la matri            
			Console.WriteLine("Defina la letra mandatoria: ");
            mand = (char.Parse(Console.ReadLine()));
			// Se setean los valores de los puntajes y las palabras de acuerdo 
			// al tamanio de la matriz introducido
			game.setUpMatrix(szMatrix, mand);
			
			// Se pregunta al usuario las letras en cada posicion de la matrix
			Console.WriteLine("Escriba los valores para la matrix:");
            for (int i = 0; i <szMatrix ; i++)
                for (int j = 0; j < szMatrix; j++)
                {
                    Console.WriteLine("[" + i + "] [" + j + "] :");
                    game.matrix[i, j] = char.Parse(Console.ReadLine());
                }
			// ic es contador para guardar las letras de la matrix en una variable cadena y  una lista de caracteres
			//  de la matriz
			
            
            
            game.setLetters();
            
			
            Console.ReadLine();
            game.Backtracking(game.word,trie);
            game.setHighScore();
			Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
			game.ShowHighScore();
            Console.ReadLine();

            //trie.Permutation(charArr,0);
        }

    }

	// clase con la matrix, los puntajes y demas elementos que conforman el juego
	public class Game
	{
		int maxScore; // Puntaje mas alto 
		
		int szMatrix;// tamanio de la matrix		
    	public char[,] matrix; // Matriz
		string[] matrixWords; // Letras correctas dentro de la matriz
	    int[] Scores; // Posee en un arreglo los puntos de cada palabra de la matriz	
        int[] highScores; // Arreglo con los valores mas altos
		string[] wordMax; // Arreglo con las palabras de mayor valor
        public string word; // cadena con las palabras de la matriz        
        string[] words; // cadena con las palabras que se encuentran dentro de la permutacion de la matriz
        public char[] letters; // arreglo con las letras de la matriz        	
        bool[] flags; // contendra las posiciones en donde si y en donde no se ha permutado
		string[] maxWords; // se guardan las palabras con el mas alto valor
		char mand; // letra mandatoria
		
		// Constructor de la clase game
		public Game () 
		{	// solo inicia el tamanio de la matrix en 0
			szMatrix =0;
		}
		// Setea todos los valores de los arreglos y variables de acuerdo al tamanio de la matrix dado
		public void setUpMatrix(int _sz, char _mand) 
		{
			if(_sz>4)
				throw new InvalidMatrixSize("Tamanio de matriz incorrecto");
            szMatrix = _sz; // Asigna el tamanio asignado a la matriz
            matrix = new char[szMatrix, szMatrix];
            flags = new bool[szMatrix * szMatrix]; // Un arreglo de banderas para controlar cuando se ha permutado x palabra en esa posicion
            words = new string[szMatrix * szMatrix];
			Scores = new int[szMatrix * szMatrix]; // se inicializa la lista con los puntajes por palabras dentro de la matriz	
            for (int i = 0; i < (szMatrix * szMatrix); i++) // Se asigna falso a todas las posiciones del arreglo de flags
                flags[i] = false;
			matrixWords = new string[szMatrix * szMatrix];
            letters = new char[szMatrix * szMatrix]; // se inicializa la lista de letras que tiene la matrix
            mand = _mand; // se asigna la letra mandatoria
			maxWords = new string[szMatrix * szMatrix];// se asigna tamanio para las palabras con valores mas altos
            maxScore = 0; // como aun no se ha encontrado un valor maximo, por ahora, sera 0
		}
		// Setea las letras en la matrix en la lista de la clase
		// y aparte, las pone todas en una variable word
		public void setLetters() {
			
			// ic es contador para guardar las letras de la matrix en una variable cadena y  una lista de caracteres
			//  de la matriz
			
			int ic=0;
			for (int i = 0; i < szMatrix; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < szMatrix; j++)
                {
                    Console.Write(" [" + i + "] [" + j + "]: " +matrix[i, j]);
                    word += Convert.ToString(matrix[i, j]); // se guarda el valor de la matriz en un string word
                    letters[ic] = (matrix[i, j]);  // se guardan las letras de la matriz en una lista letters
                    Console.WriteLine("!!!!!");
                    Console.WriteLine(letters[ic]);
                    ic++; // avanza el contador
                }

            }
            Console.WriteLine(word);
			
		}
		
		// Muetra las puntuaciones mas altas encontradas en el diccionario con su puntuacion al lado
		public void ShowHighScore()
        {
            for (int i = 0; i < Scores.Length; i++)				
                	Console.WriteLine(maxWords[i] + ": " + highScores[i]);

        }
        
        // Setea solo el valor mas alto
        public void setHighScore()
        {
        	int ic=0; // contador para guardar los valores y cadenas mayores
        	
			highScores = new int[matrixWords.Length];
			
        	// Busca todos los valores altos para ubicar solo los mayores valores existentes
        	for (int i = 0; i < matrixWords.Length; i++) {
        		// Si el mayor valor conocido durante la permutacion es igual al mayor de entre los mayores
        		// toma ese valor, se usa para solo tomar los valores mayores y las  cadenas con valores mayores
        		if(maxScore == Scores[i]) {
        			maxWords[ic] = matrixWords[i];
        			highScores[ic] = maxScore;
        			ic++;
        			
        		}
				
                //Console.WriteLine(matrixWords[i] + ": " + Scores[i]);
            }
        	
            for (int i = 0; i < letters.Length; i++)
                Console.WriteLine(maxWords[i] + ": " + Scores[i]);
                

        }
		
		// Asigna la letra mandatoria			
		public void setMandatoryLetter(char _mand)
        {
            mand = _mand;
        }
		
		// Devuelve el tamanio de la matrix
		public int SizeMatrix()
        {
            return szMatrix;
        }

		
        public void Backtracking(string _word ,Trie trie)
        {            		
            //Llamamos al método recursivo
            Backtracking(_word,"",trie);
        }

        public void Backtracking(string _word,string wordPerm, Trie trie)
        {
            String temp = _word; // se toma como valor temporal la cadena de todas las letras de la matriz
			
			int szMatrix = _word.Length;// szMatriz es el tamanio total de la cadena con todas las letras de la matriz, es decir szMatrix = ancho*largo de la matriz
			
            int j = 0; // contador para
			// SE itera la palabra y se toman cada una de las letras de el, para luego usarlas en la iteracion
			
			for (int i = 0; i < szMatrix; i++)
			{
                letters[i] = char.Parse(temp.Substring(0, 1));
                temp = temp.Remove(0, 1);
            }
            // Si en la palabra se encuentradfdf el caracter mandatorio
            if (wordPerm.Contains(Convert.ToString(mand)))
            {	// si la palabra existe en el Trie
                if (trie.Find(wordPerm) != 0)
				{
					if(maxScore <= trie.Find(wordPerm)) {						
						maxScore = trie.Find(wordPerm);
						Scores[j] = maxScore;
						matrixWords[j] = wordPerm;
						
						Console.WriteLine("MAX");
						Console.WriteLine(wordPerm + "XXXX : " + trie.Find(wordPerm) +" Max:" + maxScore);
						j++;
					}                    
					//Scores[j] = trie.Find(wordPerm);
                    Console.WriteLine(wordPerm + "! : " + trie.Find(wordPerm));
                    _word = wordPerm;
                    
                    
                }
            }
            //  Console.WriteLine("!!! " + flags.Length);
           
            
            for (int i = 0; i < szMatrix; i++)
            {
         
                			//Vemos si está marcada para no volverla a permutar
            	if (flags[i] != true)
                {
                    //Marcamos el caracter que vamos a permutar
                	flags[i] = true;
                    // Hacemos backtraking con un caracter mas
                    Backtracking(_word,wordPerm + letters[i], trie);
                    // Validamos el uso del caracter para usarlo en otra recursion                    
                    flags[i] = false;
                	
            	}
            }
            
        }

	
	}

    public class Trie
    {


        int size;    // tamanio del Trie
     	public TrieNode root = new TrieNode();
		
        public Trie()
        {
            // Constructor
            // se inicializan los tamanios de la matriz y del Trie			
            size = 0;
			
          			
        }
        // Asigna el tamanio dado a la matriz que contendra los valores introducidos por el usuario
        // Asigna el tamanio a los arreglos de score, de flgas, de letras y de palabras 

        // Funcion modifica la variable con el caracter mandatorio
      
        // Retorna el size del Trie
        public int Size()
        {
            return size;
        }

      
		public void Insert(string word, int _val)
        {
            // se inserta una palabra dentro del Trie
            // Se hace una variable temporal que tome a la palabra introducida
            string temp = word;

            // SE toma cur como la raiz en donde comenzara a preguntar
            TrieNode cur = root;

            while (temp.Length != 0)
            {

                // busca la primera letra de la palabra introducida
                // y entra en el nodo de aquella primera letra para ir iterando hasta
                // confirmar que se ha encontrado toda la palabar
                // Toma el primer caracter de la palabra
                char chr = Convert.ToChar(temp.Substring(0, 1));
                int idx = chr - 65;

                //verifica si el valor a insertar es valido, es decir, si es mayuscula de A hasta Z
                if ((chr - 65) >= 0 && (chr - 65) < 26)
                {
                    if (cur.ar[idx] == null)
                    {

                        if (temp.Length == 1)
                        {

                            cur.ar[idx] = new TrieNode(chr, _val);                          
                            break;
                        }
                        else
                        {
                            cur.ar[idx] = new TrieNode(chr, 0);
                            cur = cur.ar[idx];
                        }
                        // Si en este nodo de Trie, el valor buscado no es igual al dado por la letra
                        // Crea ese nodo en esa posicion
                        // Se resta 65 para obtener el indice de la posicion de la letra a donde deberia estar la que se va a insertar
                        // Si no existe se nodo, crea el nodo y continua
                    }
					
                    else if ( cur.ar[idx]!=null)
                    {
                     	if(temp.Length==1)
							cur.ar[idx].val = _val;
						else
						//   cur = new TrieNode(chr, 0);             
                        	cur = cur.ar[idx];
                        // de lo contrario, si existe, entra a ese nodo
                    }
                }
                else // Si se introduce un valor que no sea entre 'A' hasta 'Z'
                    throw new InvalidDataException();

                temp = temp.Remove(0, 1);
                size++;

            }

        }

     	// carga el diccionario con los datos
        public void LoadDict()
        {
        	// Guarda el valor de la linea en el archivo
            String line;
            // Read the file and display it line by line.
			// Carga el archivo dict.txt
            StreamReader file = new System.IO.StreamReader("dict.txt");
            String[] splited; // Arreglo con el valor de la linea separado
            while ((line = file.ReadLine()) != null) // mientras haya linea en el archivo, busca las lineas
            {
				// Divide las lineas entre espacio en blanco
                splited = line.Split(' ');
                // Envia a insert la palabra, y el valor de la palabra
                Insert(splited[0], int.Parse(splited[1]));

            }
            // Cuando no hayan mas lineas, cierra el archivo

            file.Close();

        }
        
        

        public int Find(string word)
        {

            // Se hace una variable temporal que tome a la palabra introducida
            if (word.Length == 0)
                return 0;
            string temp = word;
            // SE toma cur como la raiz en donde comenzara a preguntar
            TrieNode cur = root;
            
            int chr = 0;
            while (temp.Length != 0)
            {

                // busca la primera letra de la palabra introducida
                // y entra en el nodo de aquella primera letra para ir iterando hasta
                // confirmar que se ha encontrado toda la palabar
                chr = Convert.ToChar(temp.Substring(0, 1));
               // Console.WriteLine(temp.Substring(0, 1) + " char " + chr);
				//Console.WriteLine(temp.Substring(0, 1) + " LEGNTH:  " + temp.Length);
               
                // verifica si el valor ascii de la letra buscada esta entre el rango de 65 a 90, es decir, mayusculas de A hasta Z
                if (  0 <= (chr - 65)  && (chr - 65) < 26) {
                    if (cur.ar[chr - 65] != null && temp.Length == 1) {

                  //      Console.WriteLine("@!Char: " + temp.Substring(0, 1) + " Val: = " + cur.val);
                        cur = cur.ar[chr - 65];
					//	Console.WriteLine("@!Char: " + temp.Substring(0, 1) + " Val: = " + cur.val);
                        break;
                    }
                    else if (cur.ar[chr - 65] != null) {

                        //    Console.WriteLine("Char: " + temp.Substring(0, 1) + " Val: = " + cur.ar[chr - 65].val);
                        cur = cur.ar[chr - 65];

                    }
                    else // si hay algun nodo que este vacio, devuelve 0
                        return 0;
                    temp = temp.Remove(0, 1);

                }
                else //devuelve 0 si el caracter no esta entre el valor ascii 65 y 91 
                    return 0;
            }


            // al terminar el recorrido, devuelve el val de la ultima letra, que significara el valor de la palabra completa
            //return cur.val;
            return cur.val;
        }

        public int Key(char _key)
        {

            int i = 0;
            for (i = 0; i < 26; i++)
                if (_key == root.ar[i].key)
                {

                    //Console.WriteLine(root.ar[i].key + " " + " val:! " + root.ar[i].val);
                    break;
                }

            // Si no encuentra la palabra
            // devuelve 0
            return root.ar[i].val;
        }



    }

    public class TrieNode
    {

        public char key;

        public int val;
        public int size; //
        // sera el fin de la palabra hasta que se demuestre lo contrario

        // hijos de Trie
        public TrieNode[] ar = new TrieNode[26];

        public TrieNode()
        {
            val = 0;
            // this must be the solution but doens't work
            // J posee el valor ascii de la primera letra del abecedario en mayuscula
        }


        public TrieNode(char _key, int _val)
        {

            // J posee el valor ascii de la primera letra del abecedario en mayuscula
            key = _key;

            val = _val;

            size = 1;

        }

        public TrieNode(int _key, int _val)
        {

            key = Convert.ToChar(_key);
            val = _val;
            size = 1;

        }
     }  
        //excepciones
        // Excepciones
	// Excepcion para operaciones con arbol vacio
	public class InvalidMatrixSize : System.Exception
	{
    //Constructors. It is recommended that at least all the
    //constructors of
    //base class Exception are implemented
    	public InvalidMatrixSize() : base() { }
			public InvalidMatrixSize(string message) : base(message) { }
    	public InvalidMatrixSize(string message, Exception e) : base(message, e) { }
    	private string strExtraInfo;
    	public string ExtraErrorInfo 
    	{ 
    	get { return strExtraInfo;  }
        set { strExtraInfo = value; }
    	}
	}
	
	}
