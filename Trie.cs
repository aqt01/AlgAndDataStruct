using System;

namespace Trie
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Trie thing = new Trie();
			string hol = "hola";
			hol = thing.insert(hol.ToString());
			Console.WriteLine(hol);
			Console.WriteLine(thing.Key('Z') );
		}
	}
	
	class Trie 
	{
		int size;
		TrieNode [] ar = new TrieNode[26];
		
		public Trie() 
		{
			int j = 65;	
			for(int i=0 ; i<26 ; i++) {
				
				ar[i]= new TrieNode(j,j);
				j++;
			}
		}
		
		public void Insert(string word)
		{
			// inserta la palabra dentro del trie
			string temp = word;
			TrieNode cur = null;
			while(temp.Length!=0)
				{				
					// busca la primera letra de la palabra introducida
					// y entra en el nodo de aquella primera letra para ir iterando hasta
					// confirmar que se ha encontrado toda la palabar
					int j=0,k=1;
				
					for(int i = 0; i<26 ; i++)
						if (ar[i].key==temp.Substring(j,k))	{
							Console.WriteLine(temp.Substring(j,k));
							cur = ar[i];
						}
				
					while(cur!=null) 
					{
						for(cur.)
					}
					
				}
			
		}
		
		public int Find(string word)
		{
			// Si no encuentra la palabra
			// devuelve 0			
			return 0;
		}
		
		public int Key(char _key)
		{
			int i=0;
			for( i=0; i< 26 ; i++)
				if (_key == ar[i].key) 
				{
					Console.WriteLine(ar[i].key +" " +" val:! " +ar[i].val);
					break;
				}
			// Si no encuentra la palabra
			// devuelve 0	
			
			return ar[i].val;
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
		public TrieNode L,R; //Left and Right Trienode
		
		public TrieNode(char _key, char _val) 
		{
			key = _key;
			val = _val;
		}
		
		public TrieNode(int _key, int _val) 
		{
			key = Convert.ToChar(_key) ;
			val = _val;
		}
	}
}
