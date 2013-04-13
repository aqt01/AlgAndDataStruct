using System;

using System.IO;

namespace Trie
{
    class MainClass
    {

        public static void Main(string[] args)
        {

            Trie thing = new Trie();
            thing.LoadDict(); // Se carga el diccionario con todas las palabras
			
			int szMatrix;// tamanio de la matrix		
    	    char[,] matrix; // Matriz
			string[] matrixWords; // Letras correctas dentro de la matriz
	     	int[] scores; // Posee en un arreglo los puntos de cada palabra de la matriz	
        	string[] wordMax; // Arreglo con las palabras de mayor valor
        	string word; // cadena con las palabras de la matriz        
        	string[] words; // cadena con las palabras que se encuentran dentro de la permutacion de la matriz
        	char[] letters; // arreglo con las letras de la matriz        	
        	bool[] flags; // contendra las posiciones en donde si y en donde no se ha permutado
        	char mand; // letra mandatoria
			
						
			Console.WriteLine("Initial Testings! ...");
            Console.WriteLine("ABANDONER : " + thing.Find("ABANDONER")); // Debe retornar 1999
            Console.WriteLine("ABDOH : " + thing.Find("ABDOH"));	 // Debe retornar 1999	
            Console.WriteLine("ALZHEIMER : " + thing.Find("ALZHEIMER"));  // Debe retornar 1929       
			Console.WriteLine("THAT : " + thing.Find("THAT"));  // Debe retornar 1930
			Console.WriteLine("A : " + thing.Find("A"));  // Debe retornar 1930
			Console.WriteLine("WARY : " + thing.Find("WARY"));  // Debe retornar 1930
			Console.WriteLine("OF : " + thing.Find("OF"));  // Debe retornar 1930
			
			Console.WriteLine();
			
            Console.WriteLine("Defina el Tamanio de la matriz: "); 
            szMatrix = (int.Parse(Console.ReadLine()));	// se asigna el tamanio a la matri
            Console.WriteLine("Defina la letra mandatoria: ");
            mand = (char.Parse(Console.ReadLine())); // Se asigna el valor mandatorio con que debe generar siempre la permutacion
            
			matrix = new char[szMatrix, szMatrix];
            flags = new bool[szMatrix * szMatrix]; // Un arreglo de banderas para controlar cuando se ha permutado x palabra en esa posicion
            words = new string[szMatrix * szMatrix]; // Se inicializa 

            
            letters = new char[szMatrix * szMatrix]; // se inicializa la lista de letras que tiene la matrix
            scores = new int[szMatrix * szMatrix]; // se inicializa la lista con los puntajes por palabras dentro de la matriz
            word = "";		
			matrix = new char[szMatrix,szMatrix];			
			matrixWords = new string[szMatrix*szMatrix];
			
			Console.WriteLine("Escriba los valores para la matrix:");
            for (int i = 0; i <szMatrix ; i++)
                for (int j = 0; j < szMatrix; j++)
                {
                    Console.WriteLine("[" + i + "] [" + j + "] :");
                    matrix[i, j] = char.Parse(Console.ReadLine());
                }

            int ic = 0;
            for (int i = 0; i < szMatrix; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < szMatrix; j++)
                {
                    Console.Write(" [" + i + "] [" + j + "]: " + matrix[i, j]);
                    word += Convert.ToString(matrix[i, j]);
                    letters[ic] = (matrix[i, j]);
                    ic++;
                }

            }
          
			
			
			
            Console.ReadLine();
            thing.Backtracking(word,words,matrixWords,letters,scores,mand);
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.ReadLine();

            //thing.Permutation(charArr,0);
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

     
        public void LoadDict()
        {

            String line;
            // Read the file and display it line by line.

            StreamReader file = new System.IO.StreamReader("dict.txt");
            String[] splited;
            while ((line = file.ReadLine()) != null)
            {

                splited = line.Split(' ');
                Insert(splited[0], int.Parse(splited[1]));

            }

            file.Close();

        }
        // int sz es el tamanio de la matriz
        // int pos, la posicion a donde comenzar la permutacion
        // String s, la cadena en donde se guardara el resultado de las permutaciones

        //Backtrackin wrapper

        public void Backtracking(string word, string [] words,string[] matrixWords,char[] letters,int[] scores,char mand)
        {
            //Iniciamos este array auxiliar para
            //marcar los caracteres que ya combinamos
			int szMatrix =matrixWords.Length;
            bool[] flags = new bool  [szMatrix*szMatrix];
			
			for (int i = 0; i < (szMatrix * szMatrix); i++) // Se asigna falso a todas las posiciones del arreglo de flags
                flags[i] = false;
			
            //Llamamos al método recursivo
            Backtracking(word,"",matrixWords,letters,scores,flags,mand);
        }

        public void Backtracking(string word, string wordPerm, string[] matrixWords, char[] letters, int[] scores, bool[] flags, char mand)
        {
            //Imprimimos la combinación si ya cambiamos
            //todas las letras una vez
			String temp = word; // se toma como valor temporal la cadena de todas las letras de la matriz
			
			int szMatrix = word.Length;
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
                if (Find(wordPerm) != 0)
                {
                    scores[j] = Find(wordPerm);
                    //wordMax[j] =wordPerm ;
                    matrixWords[j] = wordPerm;
                    word = wordPerm;
                    Console.WriteLine(wordPerm + "! : " + Find(wordPerm));
                    j++;
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
                    Backtracking(word, wordPerm + letters[i], matrixWords,letters, scores, flags,mand);
                    // Validamos el uso del caracter para usarlo en otra recursion                    
                    flags[i] = false;
                	
            	}
            }
            
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

}
