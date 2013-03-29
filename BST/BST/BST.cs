using System;
using System.Collections.Generic;

namespace BSTTree
{
	public class MainClass
	{
		public static void Main ()
		{
			BSTBB1 bst = new BSTBB1();
			/*
			bst.AddNode(1,1);
			bst.AddNode(2,3);
			bst.AddNode(3,3);
			*/
			
			bst.AddNode (10, 1);
			bst.AddNode (20, 3);
			bst.AddNode (15, 4);
			bst.AddNode (25, 5);
			bst.AddNode (30, 6);
			bst.AddNode (15, 7);
			bst.AddNode (14, 8);
			bst.AddNode (17, 9);
			bst.AddNode (16, 10);
			bst.AddNode (18, 11);
			bst.AddNode (19, 12);
			
			// 30 more
			
			bst.AddNode (40, 1);
			
			bst.AddNode (5, 13);
			bst.AddNode (4, 14);
			bst.AddNode (8, 15);
			bst.AddNode (9, 16);
			bst.AddNode (7, 17);
						
			
			bst.print (bst.getRoot ());
			Console.WriteLine (bst.max (bst.getRoot ()).key);			
			Console.WriteLine (bst.min (bst.getRoot ()).key);
			// Must implemnet an stack
			//Console.WriteLine(bst.next(1).key);			
			
			
			
			/*
			bst.DeleteNode (4);
			
			
			bst.DeleteNode (25);
			
			bst.DeleteNode (30);
			bst.DeleteNode (40);
			
			
			*/
			bst.DeleteNode (20);
			Console.WriteLine ("After 25 delete");
			
//n			Console.WriteLine (" left 20" + bst.FindNode(30).L.key);
			bst.print (bst.getRoot ());
			//Console.WriteLine (bst.FindNode (20).R.key);
			 
									
		}
	}
	
	public class BST
	{

		int size;
		TreeNode root;
			
		public BST ()
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
		
		
		public int nodeSize(TreeNode x)
		{
			return x.size;
		}
		
		public int min_Size(TreeNode x) 
		{
			return nodeSize(x.R);
		}
		
		public int max_Size(TreeNode x) 
		{
			return nodeSize(x.R);
		}
		
		public double balanced_Factor(TreeNode X) 
		{
				return (max_Size(X.R)/ (min_Size(X.L)+1));
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
					
				 
			while (cur!=null)
			{
				// Cuando encuentre el valor a eliminar
				// Entra en esa posicion y ademas de eliminar,
				// Busca al sustituto para esa posicion
				
				if (cur.key == _key) 
				{
					if (OT) 
					{
						if (cur.R != null) {
							temp = cur.R;
							
							if (temp.L != null) {
								Console.WriteLine ("!!!!" + cur.key);
								Console.WriteLine (temp.key);
								temp = min (temp.L,ref prev); 
								Console.WriteLine (temp.key);								
								cur.val = temp.val;
								cur.key = temp.key;
								
								if (temp.R!=null) // Si el min tiene hijos a su derecha
									prev.L = temp.R;
								
								// debo hacer el previos de ese min en su izquierda null
								prev.L = null;
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
								temp = max (temp.L, ref prev); 
								Console.WriteLine (temp.key);								
								cur.val = temp.val;
								cur.key = temp.key;
									
								// se debe confirmar si tiene derecha o izquierda este nodo //if()									
								temp = null;
								prev.R = null;
									
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
		
		
		/*
		
		public TreeNode bef_max (TreeNode x, TreeNode prev)
		{

			TreeNode cur = x;
			//TreeNode _cur = root;

			while (cur.R!=null) 
			{
				prev = 
				cur = cur.R;
			}
			return cur;
		}
		
		public TreeNode bef_min (TreeNode x, TreeNode prev)
		{

			TreeNode cur = x;
			//TreeNode _cur = root;

			while (cur.L!=null) 
			{
				prev = 
					
				cur = cur.L;
			}
			return cur;
		}
		*/
		
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
		
		public TreeNode min (TreeNode x, ref TreeNode prev)
		{

			TreeNode cur = x;
			//TreeNode _cur = root;

			while (cur.L!=null) 
			{
				prev = cur;
				cur = cur.L;
			}
			return cur;
		}
			
		
		public TreeNode max (TreeNode x, ref TreeNode  prev)
		{

			TreeNode cur = x;

			while (cur.R!=null) 
			{ 	
				prev = cur;
				cur = cur.R;
			}
			return cur;
		}
		
		// if turn left, must minus the right size and start counting with the sum of its igga
		// fadfa;lj the same but in right side Not sure)
		/*
		public int rank(int _key) 
		{
			if(root==null)
				throw new InvalidOperationException();
			
			TreeNode cur = root;
			
			 int idx=0; // indice del nodo
			
			while(cur != null) 				
			{
				if(_key < cur.key)
					cur = cur.L;
				else if (_key > cur.key)
					cur = cur.R;
				
			}
		
		}
		*/
		
		
		
		public void AddNodeB (int _key, int _val)
		{
			TreeNode newNode = new TreeNode (_key, _val);			
			TreeNode curr = root;
			TreeNode temp = null;
										
			if (size == 0) 
			{		
				root = newNode;
				size++;
				return ;
			}
				
					
			Stack<TreeNode> p = new Stack<TreeNode>();
		
			while (curr!=null) {		
				
				//	temp = curr;	
				temp = curr;
				// Si el valor ya existe, reemplaza el valor del nodo
				
					
				if (_key < curr.key)
				{
					p.Push(curr);
					curr.size++;
					curr = curr.L;
					
				}
				else if (_key > curr.key)
				{	
					p.Push(curr);
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
			
			for(int i=0 ; i<p.Count;i++)		
						p.Pop().size++;
				
			
			size++;
					
			
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
			
			// should i consider this
			/*temp = FindNode(_key); 
			 * if (temp!=null)
			 * {
					temp.val = _val;
					return ;
			   }
				
			*/
			
			while (curr!=null) {		
				
				//	temp = curr;	
				temp = curr;
				// Si el valor ya existe, reemplaza el valor del nodo
				if (_key == curr.key) {
					curr.val = _val;
					return ;
				}
					
				if (_key < curr.key)
						
					curr = curr.L;
				else if (_key > curr.key)
						
					curr = curr.R;
				
				
				
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
		
	public class TreeNode
	{
		
		public TreeNode L, R	;			// parent, right and left
		//public TreeNode P;
		public int val;
		public int key;
		public int size; // subtree size
		public TreeNode (int _key, int _val)
		{	
			L = null;
			R = null;		
		//	P = null;
			key = _key;
			val = _val;
			size=1;
		}
			
		// Think this is not necessary
			
		public TreeNode ()
		{
			L = null;
			R = null;
		//	P = null;
		}
			
			
	}
}



