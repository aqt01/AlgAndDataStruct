using System;

namespace BSTTree
{
	public class BSTBB1
	{

		int size;
		TreeNode root;
			
		public BSTBB1 ()
		{			
			root = null;
			size = 0;
		}
			
		public TreeNode getRoot ()
		{
			return root;
		}		
		
		public TreeNode FindNode (int _key)
		{
				
			if (root == null)
				return null;
			
			TreeNode cur = root;
			
			while (cur!=null) {
					
				if (cur.key == _key)
					return cur;
				else if (_key > cur.key)
					cur = cur.R;
				else if (_key < cur.key)
					cur = cur.L;
									
			}
			
			return null;
				
					
		}
		
		public int Find (int _key)
		{
				
			if (root == null)
				return -1;
			
			TreeNode cur = root;
			
			while (cur!=null) {
					
				if (cur.key == _key)
					return cur.val;
				else if (_key > cur.key)
					cur = cur.R;
				else if (_key < cur.key)
					cur = cur.L;
									
			}
			
			return -1;
				
					
		}
		
		public void print (TreeNode cur)
		{				
			if (cur == null)
				return;
				
			print (cur.R);        		
			Console.WriteLine (cur.key);									
			print (cur.L);
		}
		
		public TreeNode DeleteNode (int _key)
		{
			// Node to delete
			TreeNode cur = root;
			// Node to seek
			TreeNode temp = null;
				
			TreeNode prev = null;
				
			if (cur == null)
				return null;
			
			// OT es la orientacion que tomara el hubbards delete
			// True: derecha, false: izquierda
			bool OT = true;
				
			// Si es menor el key del root, la orienacion de hubbard delete es a la izquierda
				
			if (_key < cur.key) {		
				OT = false;				
				cur = cur.L;
			} else if (_key > cur.key) // Si es mayor el key buscado en comparacion con el root.key, se dirige hacia la derecha
				cur = cur.R;				
					
				 
			while (cur!=null) {
				// Cuando encuentre el valor a eliminar
				// Entra en esa posicion y ademas de eliminar,
				// Busca al sustituto para esa posicion
				
				if (cur.key == _key) 
				{
					if (OT) 
					{
						if (cur.L != null) {
							temp = cur.L;
							
							if (temp.R != null) {
								
								Console.WriteLine (temp.key);
								temp = max (temp.R); 
								Console.WriteLine (temp.key);								
								cur.val = temp.val;
								cur.key = temp.key;
									
								// se debe confirmar si tiene derecha o izquierda este nodo //if()									
								temp = null;
									
									
								/*
									temp.R = cur.R;
									temp.L = cur.L;
									*/
							}
						} else if (cur.R != null) {
							// it must make the temp cur.L?																
							// parent connected to his new right son																						
							Console.WriteLine ("!" + cur.R.key);															
							cur = cur.R;
							prev.R = cur;
							 																
						}
							
						prev.R = null;
						cur=null;	
									
						return cur;
						
					} else 
					{
						if (cur.R != null) 
						{
							temp = cur.R;
							
							if (temp.L != null) 
							{
								
								Console.WriteLine (temp.key);
								temp = max (temp.L); 
								Console.WriteLine (temp.key);								
								cur.val = temp.val;
								cur.key = temp.key;
									
								// se debe confirmar si tiene derecha o izquierda este nodo //if()									
								temp = null;
									
									
								/*
									temp.R = cur.R;
									temp.L = cur.L;
									*/
							}
						} 
						else if (cur.L != null) 
						{
							// it must make the temp cur.L?																
							// parent connected to his new right son																						
							Console.WriteLine ("!!!" + cur.L.key);															
							cur = cur.L;
							prev.L = cur;
							 																
						}		
						prev.L = null;
						cur=null;					
					}
				} else if (_key > cur.key) {
					prev = cur;
					cur = cur.R;					
				} else if (_key < cur.key) {
					prev = cur;
					cur = cur.L;
				}
									
			}
			
			return null;
				
				
				
				
		}
		
		public TreeNode min (TreeNode x)
		{

			TreeNode cur = x;
			//TreeNode _cur = root;

			while (cur.L!=null) {
				cur = cur.L;
			}
			return cur;
		}
			
		public TreeNode next (int _key)
		{	
			TreeNode best = null;
			TreeNode cur = root;
	
			if (root == null)
				return null;
			
			while (cur!=null) {
	
				if (_key > cur.key) {
					cur = cur.R;
				} else {
					best = cur;
					cur = cur.R;
				}
	
			}
			
			return best;	
		}
		
		public TreeNode max (TreeNode x)
		{

			TreeNode cur = x;

			while (cur.R!=null) { 	
				cur = cur.R;
			}
			return cur;
		}
		
		public void AddNode (int _key, int _val)
		{
								
			TreeNode newNode = new TreeNode (_key, _val);			
			TreeNode curr = root;
			TreeNode temp = null;
										
			if (size == 0) {		
				root = newNode;
				size++;
				return ;
			}
				
				
			while (curr!=null) {		
				
				//	temp = curr;	
				temp = curr;
				// Si el valor ya existe, reemplaza el valor del nodo
				if (_key == curr.key) {
					curr.val = _val;
					return ;
				}
					
				if (_key < curr.key)
				{
					curr.size++;
					curr = curr.L;
					
				}
				else if (_key > curr.key)
				{	
					curr.size++;
					curr = curr.R;
				}
				
				
			}	
			
					
			if (_key > temp.key) { 
				curr = new TreeNode (_key, _val);
				temp.R = curr;
			} else if (_key < temp.key) {
				curr = new TreeNode (_key, _val);
				temp.L = curr;
			}
				
				
			
			size++;
					
			
		}
			
	
	}
		
}


