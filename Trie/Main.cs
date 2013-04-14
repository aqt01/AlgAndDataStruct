using System;

using System.Collections.Generic;
using System.IO;

namespace Trie
{
    class MainClass
    {

        public static void Main(string[] args)
        {

            Trie trie = new Trie(); // se crea un objeto de trie
			Game game = new Game(); // se crea un objeto de la clase game
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
			
			
			Console.WriteLine("Done! ...");
			
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
			// setletters organiza las letras dentro de un arreglo y dentro de una palabra que luego se usara para permutar                        
            game.setLetters();
            
			Console.WriteLine ("Press any key to generate permutations");
            Console.ReadLine();
            game.Backtracking(game.word,trie);
            game.setHighScore(); // Organiza y solo toma los valores y las palabras mas altas en sus respectivas listas
			Console.WriteLine("Highest scores and words of the permutations: ");
			game.ShowHighScore(); // muestra las palabras y los valores mas altos
            Console.ReadLine();
            
        }

    }

	// clase con la matrix, los puntajes y demas elementos que conforman el juego
	public class Game //nice@
	{
		int maxScore; // Puntaje mas alto 
		int j; // contador para ir recorriendo y guardando en los arreglos de highscore y maxscore
		int szMatrix;// tamanio de la matrix		
    	public char[,] matrix; // Matriz
		List<string> matrixWords; // Letras correctas dentro de la matriz
	    List<int> Scores; // Posee en un arreglo los puntos de cada palabra de la matriz	
        List <int> highScores; // LIsta con los valores mas altos
		List <string> wordMax; // lista con las palabras de mayor valor
        public string word; // cadena con las palabras de la matriz        
         public char[] letters; // arreglo con las letras de la matriz        	
        bool[] flags; // contendra las posiciones en donde si y en donde no se ha permutado
		char mand; // letra mandatoria
		
		// Constructor de la clase game
		public Game () 
		{	// solo inicia el tamanio de la matrix en 0
			szMatrix =0;
		}
		// Setea todos los valores de los arreglos y variables de acuerdo al tamanio de la matrix dado
		public void setUpMatrix(int _sz, char _mand) 
		{
			if(_sz>4)// si el tamanio es mayor que 4, tira excepcion
				throw new InvalidMatrixSize("Tamanio de matriz incorrecto");
            szMatrix = _sz; // Asigna el tamanio asignado a la matriz
            matrix = new char[szMatrix, szMatrix]; // se inicializa la matrix
            matrixWords = new List<string>();  // se inicializa la lista de palabras de la matriz, en ella se guardaran las palabras que se iran comparando, hasta ser la mas grande
		    Scores = new List<int>();  // se inicializa la lista de scores, en ella se guardaran las puntuaciones a medida que vayan creciendo hasta ser la mas grande
        	highScores = new List<int>() ; // contiene las puntuaciones mas altas
			wordMax = new List<string>();  // Contiene las palabras con las puntuaciones mas altas
    
			flags = new bool[szMatrix * szMatrix]; // Un arreglo de banderas para controlar cuando se ha permutado x palabra en esa posicion
            for (int i = 0; i < (szMatrix * szMatrix); i++) // Se asigna falso a todas las posiciones del arreglo de flags
                flags[i] = false;
		    letters = new char[szMatrix * szMatrix]; // se inicializa la lista de letras que tiene la matrix
            mand = _mand; // se asigna la letra mandatoria
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
					// muestra el valor dentro de esa posicion
                    Console.Write(" [" + i + "] [" + j + "]: " +matrix[i, j]);
					Console.Write(" ");
                    word += Convert.ToString(matrix[i, j]); // se guarda el valor de la matriz en un string word
                    letters[ic] = (matrix[i, j]);  // se guardan las letras de la matriz en una lista letters                    					
                    ic++; // avanza el contador
                }

            }
			
		}
		
		// Muetra las puntuaciones mas altas encontradas en el diccionario con su puntuacion al lado
		public void ShowHighScore()
        {
            for (int i = 0; i < wordMax.Count; i++)				
                	Console.WriteLine(wordMax[i] + ": " + highScores[i]);

        }
        
        // Setea solo el valor mas alto
        public void setHighScore()
        {
        	int ic=0; // contador para guardar los valores y cadenas mayores
        	
			// Busca todos los valores altos para ubicar solo los mayores valores existentes
        	for (int i = 0; i < Scores.Count; i++) {
        		// Si el mayor valor conocido durante la permutacion es igual al mayor de entre los mayores
        		// toma ese valor, se usa para solo tomar los valores mayores y las  cadenas con valores mayores
        		if(maxScore == Scores[i]) {
        			wordMax.Add (matrixWords[i]);
        			highScores.Add ( maxScore);
        			ic++;
        		}
				
                
            }
        	                

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
			
            // contador para
			// SE itera la palabra y se toman cada una de las letras de el, para luego usarlas en la iteracion
			int score; // posee la puntuacion de la palabra a permutar
			
			for (int i = 0; i < szMatrix; i++)
			{
                letters[i] = char.Parse(temp.Substring(0, 1));
                temp = temp.Remove(0, 1);
            }
            // Si en la palabra se encuentradfdf el caracter mandatorio
            if (wordPerm.Contains(Convert.ToString(mand)))
            {	// si la palabra existe en el Trie
				score=trie.Find(wordPerm);
				// si la variable score posee puntaje quiere decir que la palabra existe dentro del Trie
                if ( score!= 0) { 
					if(maxScore <= score) {	// si ese puntaje es menor o igual que el maximo puntaje conocido, es reemplazado por el puntaje actual
						maxScore = score;
						Scores.Add (maxScore);
						matrixWords.Add(wordPerm); // se agrega la palabra en ese momento
						
					}                    
					//Scores[j] = trie.Find(wordPerm);
                    _word = wordPerm;
                    
                    
                }
            }
            //  Console.WriteLine("!!! " + flags.Length);
           
            // Hacemos las recursiones con los valores de la matriz
            for (int i = 0; i < szMatrix; i++)
            {
         
                // La verificacion se realiza siempre y cuando no se haya marcado esa posicion de la matriz
            	if (flags[i] != true)
                {
                    // El caracter es marcado para indicar que fue usado
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
     	public TrieNode root; // se crea la raiz del  Trie
		
        public Trie()
        {
            // Constructor
            // se inicializan los tamanios de la matriz y del Trie			
            size = 0;
			// se crea la raiz de Trie
			root = new TrieNode();
          			
        }
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

            // SE toma cur como la raiz en donde comenzara a mavegar
            TrieNode cur = root;

            while (temp.Length != 0)
            {

                // busca la primera letra de la palabra introducida
                // y entra en el nodo de aquella primera letra para ir iterando hasta
                // confirmar que se ha encontrado toda la palabar
                // Toma el primer caracter de la palabra
                char chr = Convert.ToChar(temp.Substring(0, 1));
				// toma el indice de acuerdo al caracer ascii de donde deberia estar esa palabra
                int idx = chr - 65;

                //verifica si el valor a insertar es valido, es decir, si es mayuscula de A hasta Z
                if ((idx) >= 0 && (idx) < 26)
                {
					// si en esta posicion debajo, es nula
                    if (cur.ar[idx] == null)
                    {
						// ya que se conoce que se creara un valor al entrar en un nodo nulo, se incrementa el size
						 size++;
						// si al entrar, a la palabra introducida solo le queda una letra por eliminar
                        if (temp.Length == 1)
                        {
							// se crea debajo el nodo con el caracter y el valor y sale del for
                            cur.ar[idx] = new TrieNode(chr, _val);  							
                            break;
                        }
                        else // si no es la ultima letra por eliminar y esta vacio
                        { 
							// se crea debajo un nodo sin valor, es decir, 0, con el caracter dado
                            cur.ar[idx] = new TrieNode(chr, 0);
                            cur = cur.ar[idx]; // navega dentro de ese nodo creado							
                        }
                    }
					// si esa posicion ya posee valor
                    else if ( cur.ar[idx]!=null)
                    {	// si ya posee valor y solo le queda una letra por eliminar a la palabra
                     	if(temp.Length==1)
							cur.ar[idx].val = _val; // se cambia el valor de la palabra, pues ya existe
						else // si no es el ultimo valor por eliminar, solo navega adentro de ese nodo						
                        	cur = cur.ar[idx];
                        	// de lo contrario, si existe, entra a ese nodo
                    }
                }
                else // Si se introduce un valor que no sea entre 'A' hasta 'Z', tira excepcion
                    throw new InvalidDataException();
				// luego de cada asignacion o navegacion, se remueve una letra de la palabra temporal
                temp = temp.Remove(0, 1);
               

            }

        }

     	// carga el diccionario con los datos
        public void LoadDict()
        {
        	// Guarda el valor de la linea en el archivo
            String line;
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
                int idx = chr - 65;
                // verifica si el valor ascii de la letra buscada esta entre el rango de 65 a 90, es decir, mayusculas de A hasta Z
                if (  0 <= (idx)  && (idx) < 26) {
                    if (cur.ar[idx] != null && temp.Length == 1) {                
                        
						cur = cur.ar[idx];					
                        break;
						
                    }
                    else if (cur.ar[idx] != null) {

                        cur = cur.ar[idx];

                    }
                    else // si hay algun nodo que este vacio, devuelve 0
                        return 0;
                    // se remueve la palabra de alante
					temp = temp.Remove(0, 1);

                }
                else //devuelve 0 si el caracter no esta entre el valor ascii 65 y 91 
                    return 0;
            }


            // al terminar el recorrido, devuelve el val de la ultima letra, que significara el valor de la palabra completa            
            return cur.val;
        }



    }

    public class TrieNode
    {
        public char key;
        public int val;
        
        // hijos de Trie
        public TrieNode[] ar = new TrieNode[26];

        public TrieNode()
        {
            val = 0; // al construirlo, lo construye con valor 0
        }


        public TrieNode(char _key, int _val)
        {

            // se asignan los valores dados en las respectivas posiciones de key y de val
			
            key = _key;

            val = _val;


        }
		// en caso de que el valor de key introducido sea numero, convierte ese valor de numero a valor ascii
        public TrieNode(int _key, int _val)
        {

            key = Convert.ToChar(_key);
            val = _val;
            

        }
     }  
     // Excepciones
	// Excepcion para devolver cuando se introduce un valor N>4 en la matrix
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
