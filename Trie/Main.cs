using

System;

namespace

Trie
{

    class MainClass
    {

        public static void Main(string[] args)
        {

            Trie thing = new Trie();

            string hol = "HOLA";

            thing.Insert(hol,5);

            Console.WriteLine(hol);

          
            Console.WriteLine("Char VAL!: " + thing.Find(hol) );
			
        }

    }

    class Trie
    {
        // tamaño del Trie

        int size;

        // Se crea un arreglo de 26

        // que representarán las letras del abecedario
        TrieNode root = new TrieNode();

        
        public Trie()
        {
            // J posee el valor ascii de la primera letra del abecedario en mayuscula
			
		
     /*       int j = 65;
            char xs;
            // Genera todas las letras de 'A' hasta 'Z'
          /*  for (int i = 0; i < 26; i++)
            {
                
                ar[i] = new TrieNode(j, j);
                xs = Convert.ToChar(j);
			
                Console.WriteLine(xs);                
                j++;

            }*/
			
			for (int i = 0; i < 26; i++)     {                    
            	root.ar[i] = new TrieNode('_',0);           
			}

        }

        public void Insert(string word, int _val)
        {
			// se inserta una palabra dentro del Trie
			// Se hace una variable temporal que tome a la palabra introducida
			
            string temp = word;
			
			// SE toma cur como la raiz en donde comenzara a preguntar
			
            TrieNode cur = root;
			//
			
			
            while (temp.Length != 0)
            {

                // busca la primera letra de la palabra introducida

                // y entra en el nodo de aquella primera letra para ir iterando hasta

                // confirmar que se ha encontrado toda la palabar
				
				
				// Toma el primer caracter de la palabra
				char chr = Convert.ToChar( temp.Substring(0, 1));
				
                int idx = chr - 65;
				Console.WriteLine( temp.Substring(0, 1) + " "+ chr + " " + idx);
				
				Console.ReadLine ();
				
			// me interesaria insertar en esa posicion que me estan dando!?
				
				// Las 3 formas de hacerlo segun yo son: tomando el valor donde deberia ir y preguntar si esta nulo
				// Llenando todo el arreglo con el alfabeto, o con algun caracter para identificar que no ha sido usado.
				// use la ultima
				//Console.WriteLine(cur.ar[idx].key);
                if ( cur.ar[idx] == null )
                {
					cur.ar[idx] = new TrieNode (chr,_val);
					cur = cur.ar[idx];	
					
					                
					// Si en este nodo de Trie, el valor buscado no es igual al dado por la letra
					// Crea ese nodo en esa posicion 
					// Se resta 65 para obtener el indice de la posicion de la letra a donde deberia estar la que se va a insertar
					// Si no existe se nodo, crea el nodo y continua
				
                } else
				{					
                 
					
               		Console.WriteLine(chr);	
					cur.ar[idx] = new TrieNode(chr,_val);
                    cur = cur. ar[idx];
					// de lo contrario, si existe, entra a ese nodo				
					
					
				}
				
				temp = temp.Remove(0,1);
				size++;
			
            }
			
			
        }

        public int Find(string word)
        {
			
				// Se hace una variable temporal que tome a la palabra introducida
			
            string temp = word;
			
			// SE toma cur como la raiz en donde comenzara a preguntar
			
            TrieNode cur = root;
			//
			int chr;
			
            while (temp.Length != 0)
            {

                // busca la primera letra de la palabra introducida

                // y entra en el nodo de aquella primera letra para ir iterando hasta

                // confirmar que se ha encontrado toda la palabar
				
				chr = Convert.ToChar( temp.Substring(0, 1));
                
				Console.WriteLine( temp.Substring(0, 1) + " "+ chr);						
				
				Console.ReadLine ();
				
                
                
					
                    if (cur.ar[chr-65] !=null)
                    {

                        Console.WriteLine(temp.Substring(0,1)+ " = " +cur.ar[chr-65].key);
                        
						if(temp.Length >1)
							cur = cur. ar[chr-65];

                    } else
						return -1;
				
				temp = temp.Remove(0,1);
				
            }
			
            // Si no encuentra la palabra

            // devuelve 0

            return cur.ar[chr-65].val;

        }

        public int Key(char _key)
        {

            int i = 0;

            for (i = 0; i < 26; i++)

                if (_key == root.ar[i].key)
                {

                    Console.WriteLine(root.ar[i].key + " " + " val:! " + root.ar[i].val);

                    break;

                }

            // Si no encuentra la palabra

            // devuelve 0

            return root.ar[i].val;

        }

        protected void Gen()
        {

        }

    }

    public class TrieNode
    {

        public char key;

        public int val;

        public int size; //
        // sera el fin de la palabra hasta que se demuestre lo contrario
        public bool wordEnd=true;
        // hijos de Trie
        public TrieNode[] ar = new TrieNode[26];
		
		public TrieNode()
        {
			
			
			//j=65;// se usa j para crear las letras de 'A' hasta 'Z'
			// se crean todas las letras del alfabeto sin valor alguno
		/*for (int i = 0; i < 26; i++)  {                          
                ar[i] = new TrieNode('_', 0);
				Console.WriteLine(ar[i].key);
			}//xs = Convert.ToChar(j);
		*/	
                //Console.WriteLine(xs);                
                //j++;

            
			// this must be the solution but doens't work
			
			for (int i = 0; i < 26; i++)                         
            	ar[i] = null;      
            
            // J posee el valor ascii de la primera letra del abecedario en mayuscula
            
        }

		
		
        public TrieNode(char _key, int _val)
        {
            // J posee el valor ascii de la primera letra del abecedario en mayuscula
            key = _key;
            val = _val;
			size =1;
        }

        public TrieNode(int _key, int _val)
        {
            key= Convert.ToChar(_key);
            val = _val;
			size = 1;
        }

    }

}
