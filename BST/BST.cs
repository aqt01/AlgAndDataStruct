using System;
using System.Collections.Generic;

namespace BSTTree
{
	public class MainClass
	{
		public static void Main ()
		{
			BST bst = new BST();
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

			bst.AddNode (1, 13);
			bst.AddNode (3, 14);
			bst.AddNode (2, 15);
			
			
			bst.AddNode (35, 1);
			bst.AddNode (31, 3);
			bst.AddNode (37, 4);
			bst.AddNode (38, 5);
			
			bst.AddNode (50, 5);
			//Console.WriteLine (bst.max (bst.getRoot ()).key);			
			//Console.WriteLine (bst.min (bst.getRoot ()).key);
			// Must implemnet an stack
			//Console.WriteLine(bst.next(1).key);			
			
			
			
			/*
			bst.DeleteNode (4);
			
			
			bst.DeleteNode (25);
			
			bst.DeleteNode (30);
			bst.DeleteNode (40);
			
			
			*/
			//bst.DeleteNode (20);
			/*
			
			bst.DeleteNode (4);
			Console.WriteLine ("After 25 delete");
			
//			Console.WriteLine (" left 20" + bst.FindNode(30).L.key);
			bst.print (bst.getRoot ());
			Console.WriteLine("Left 5 key: " + bst.FindNode(5).L.key);
			Console.WriteLine("L R 5 key: " + bst.FindNode().L.R.key);
			//Console.WriteLine("R R 5 key: " + bst.FindNode(30).R.R.key);
			//Console.WriteLine("R L 5 key: " + bst.FindNode(30).R.L.key);
			//Console.WriteLine (bst.FindNode (30).R.key);
			 */
			
			
			
			/*
			bst.DeleteNode (25);
			
			
			
			Console.WriteLine ("After 25 delete");
			
//			Console.WriteLine (" left 20" + bst.FindNode(30).L.key);
			bst.print (bst.getRoot ());
			//Console.WriteLine("R key: " + bst.FindNode(30).R.key);
			
			Console.WriteLine("R L 5 key: " + bst.FindNode(20).R.key);
			Console.WriteLine("R L 5 key: " + bst.FindNode(20).R.R.key);
			//Console.WriteLine("R L 5 key: " + bst.FindNode(20).R.R.R.key);		
			
			//Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.R.L.L.key);		
			//Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.R.L.R.key);		
			//Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.R.L.R.R.key);		
			*/
			
			
			
			// proof to delete 30
			/*
			bst.DeleteNode (30);
			Console.WriteLine ("After 40 delete");
			
//			Console.WriteLine (" left 20" + bst.FindNode(30).L.key);
			bst.print (bst.getRoot ());
			//Console.WriteLine("R key: " + bst.FindNode(30).R.key);
			
			Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.key);
			Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.R.key);
			Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.R.L.key);		
			
			//Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.R.L.L.key);		
			Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.R.L.R.key);		
			Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.R.L.R.R.key);		
			*/
			
			
			// proof to delete 30
			/*
			bst.DeleteNode (30);
			Console.WriteLine ("After 40 delete");
			
//			Console.WriteLine (" left 20" + bst.FindNode(30).L.key);
			bst.print (bst.getRoot ());
			//Console.WriteLine("R key: " + bst.FindNode(30).R.key);
			
			Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.key);
			Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.R.key);
			Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.R.L.key);		
			
			//Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.R.L.L.key);		
			Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.R.L.R.key);		
			Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.R.L.R.R.key);		
			*/
			
			
			// prueba borrando el 1, un leave con un tree en su derecha
			
			
			
			// Borrando el 1 con un
			
			/*
			bst.DeleteNode (1);
			Console.WriteLine ("After 40 delete");
			
			
			bst.print (bst.getRoot ());
			
			Console.WriteLine (" FInD:  " + bst.getRoot().key);
			
			Console.WriteLine ("Root L:  " + bst.getRoot().L.key);
			Console.WriteLine ("Root L:  " + bst.getRoot().L.L.key);
			Console.WriteLine ("Root L:  " + bst.getRoot().L.L.L.key);
			
			Console.WriteLine (" FInD:  " + bst.FindNode(3).key);
			Console.WriteLine (" L " + bst.FindNode(3).L.key);
			*/
			
			//Console.WriteLine("R L 4 key: " + bst.FindNode(1).key);
			//Console.WriteLine("R L 4 key: " + bst.FindNode(3).L.key);
			//Console.WriteLine("R L 5 key: " + bst.FindNode(3).L.L.key);
			//Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.R.L.key);		
			
			//Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.R.L.L.key);		
			//Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.R.L.R.key);		
			//Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.R.L.R.R.key);		
			//Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.R.R.key);
			//Console.WriteLine("R R 5 key: " + bst.FindNode(30).R.R.key);
			//Console.WriteLine("R L 5 key: " + bst.FindNode(30).R.L.key);
			//Console.WriteLine (bst.FindNode (30).R.key);
			
			
			
			// Borrando el 4 con un
			//hecho
			/*
			bst.DeleteNode (4);
			Console.WriteLine ("After 40 delete");
			bst.print (bst.getRoot ());
			
			Console.WriteLine (" Root:  " + bst.getRoot().key);
			Console.WriteLine ("Root L:  " + bst.getRoot().L.key);
			Console.WriteLine ("Root L L:  " + bst.getRoot().L.L.key);
			Console.WriteLine (" FInD 3:  " + bst.FindNode(3).key);
			Console.WriteLine (" 3 L " + bst.FindNode(3).L.key);
			Console.WriteLine(" 3 L R: " + bst.FindNode(3).L.R.key);
			// must blow up
			//Console.WriteLine(" 3 L R: " + bst.FindNode(3).L.R.L.key);
			
			//Console.WriteLine(" 3 L R: " + bst.FindNode(3).L.R.R.key);
			
			*/
			
			// Borrando el 5 con un
			//hecho
			/*
			bst.DeleteNode (5);
			Console.WriteLine ("After 5 delete");
			bst.print (bst.getRoot ());
			
			Console.WriteLine (" Root:  " + bst.getRoot().key);
			Console.WriteLine ("Root L:  " + bst.getRoot().L.key);
			Console.WriteLine ("Root L L:  " + bst.getRoot().L.L.key);			
			
			Console.WriteLine (" FInD 4:  " + bst.FindNode(4).key);
			
			Console.WriteLine (" 4 R:  " + bst.FindNode(4).R.key);
			Console.WriteLine (" 4 R R:  " + bst.FindNode(4).R.R.key);
			Console.WriteLine (" 4 R L:  " + bst.FindNode(4).R.L.key);
			Console.WriteLine (" 4 L: " + bst.FindNode(4).L.key);
			Console.WriteLine(" 4 L R: " + bst.FindNode(4).L.R.key);
			*/
			
			// Borrando el 17 con un
			//hecho
			/*
			bst.DeleteNode (17);
			Console.WriteLine ("After 5 delete");
			bst.print (bst.getRoot ());
			
			Console.WriteLine (" Father:  " + bst.FindNode(20).key);
			Console.WriteLine ("Father L:  " + bst.FindNode(20).L.key);
			
			Console.WriteLine ("Father L L:  " + bst.FindNode(20).L.L.key);			
			
			
			
			Console.WriteLine (" 15 R:  " + bst.FindNode(15).R.key);
			Console.WriteLine (" 15 R R:  " + bst.FindNode(15).R.R.key);
			Console.WriteLine (" 15 R L:  " + bst.FindNode(15).R.L.key);
		
			Console.WriteLine (" 15 L: " + bst.FindNode(15).L.key);
			*/
		
			// Borrando el 14 con un
			//hecho
			/*
			bst.DeleteNode (14);
			Console.WriteLine ("After 5 delete");
			bst.print (bst.getRoot ());
			
			Console.WriteLine (" Father:  " + bst.FindNode(20).key);
			Console.WriteLine ("Father L:  " + bst.FindNode(20).L.key);
			// must blow up
			//Console.WriteLine ("Father L L:  " + bst.FindNode(20).L.L.key);			
			
			
			
			Console.WriteLine (" 15 R:  " + bst.FindNode(15).R.key);
			Console.WriteLine (" 15 R R:  " + bst.FindNode(15).R.R.key);
			Console.WriteLine (" 15 R L:  " + bst.FindNode(15).R.L.key);

			// blow again
		//	Console.WriteLine (" 15 L: " + bst.FindNode(15).L.key);
			*/
			// Borrando el 19 con un
			//hecho
			/*
			bst.DeleteNode (19);
			Console.WriteLine ("After 19 delete");
			bst.print (bst.getRoot ());
			
			Console.WriteLine (" Father:  " + bst.FindNode(20).key);
			Console.WriteLine ("Father L:  " + bst.FindNode(20).L.key);
			Console.WriteLine (" 15 R:  " + bst.FindNode(15).R.key);
			Console.WriteLine (" 15 R R:  " + bst.FindNode(15).R.R.key);
			// must boom!
			//Console.WriteLine ("15 R R R :  " + bst.FindNode(15).R.R.R.key);			
			Console.WriteLine (" 15 R L:  " + bst.FindNode(15).R.L.key);
			
			*/
			
			// Borrando el 50 con un
			//hecho
			/*
			bst.DeleteNode (50);
			Console.WriteLine ("After 50 delete");
			bst.print (bst.getRoot ());
			
			
			// must blow up
			//Console.WriteLine ("30 R R:  " + bst.FindNode(30).R.R.key);											
			Console.WriteLine (" 30 R:  " + bst.FindNode(30).R.key);
			Console.WriteLine (" 30 R L:  " + bst.FindNode(30).R.L.key);
			*/
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
		
		public void DeleteNode (int _key)
		{
			// Node to delete
			TreeNode cur = root;
			// Node to seek
			TreeNode temp = null;
				
			TreeNode prev = null;
				
			if (cur == null)
				return ;
			
			// OT es la orientacion que tomara el hubbards delete
			// True: derecha, false: izquierda
			bool OT = true;
				
			// Si es menor el key del root, la orienacion de hubbard delete es a la izquierda
				
			if (_key < cur.key) {		
				OT = false;			
				prev= cur;
				cur = cur.L;
			} else if (_key > cur.key) { // Si es mayor el key buscado en comparacion con el root.key, se dirige hacia la derecha
				prev = cur;
				cur = cur.R;			
			}	
					
				 
			while (cur!=null)
			{
				// Cuando encuentre el valor a eliminar
				// Entra en esa posicion y ademas de eliminar,
				// Busca al sustituto para esa posicion
				
				if (cur.key == _key) // Si encuentra el numero a borrar
				{
					Console.WriteLine("PREV: " +prev.key);
					Console.WriteLine("Cur : " +cur.key);
					//Console.WriteLine("cur.R :" +cur.R.key);										
					Console.WriteLine("cur.R :" +OT);	
					
					if (OT) // Si el numero a borrar se encuentra en el subtree a la derecha del root
					{
						if (cur.R != null) { 
							
							temp = cur.R;
							
							Console.WriteLine("temp.R :" +temp.key);
							Console.WriteLine("prev.R :" +prev.key);
							
							if (temp.L != null) {
								
								Console.WriteLine ("!!!!"+temp.key);
								temp = min (temp.L,ref prev); 
								Console.WriteLine ("!!!!"+temp.key);								
								cur.val = temp.val;
								cur.key = temp.key;
								
								if (temp.R!=null) // Si el min tiene hijos a su derecha
									prev.L = temp.R;
								
								// debo hacer el previos de ese min en su izquierda null
								prev.L = null;
								temp = null;
								return ;
									
								/*
									temp.R = cur.R;
									 	temp.L = cur.L;
								*/
						}
							
						 else if (cur.R != null) {
							
							Console.WriteLine("temp.R !!!!!!:" +temp.key);
								Console.WriteLine("PREV !!!!!!:" +prev.key);
							// it must make the temp cur.L?																
							// parent connected to his new right son																						
							Console.WriteLine ("temp" + cur.R.key);															
								Console.WriteLine ("temp" + cur.R.key);															
								Console.WriteLine ("curR" + cur.R.key);
							prev.R = temp;
								
							if(cur.L!=null)
								temp.L = cur.L;
								
							cur = cur.R;
							
							return ;														
						}
						
						// Caso en que no posea a la derecha
						// Si no posee hijos a la izquierda ni a la derecha
						else if(temp.R==null) { // not necessary
						cur.key = temp.key;
						cur.val = temp.val;
						cur.R=null;
						temp=null;
						}
						
						//prev.R = null;
					//	cur=null;	
									
						return ;
					 }
					 		// si el nodo a borrar posee subtree o algun nodo a su izquierda
						
						else if(cur.L!=null) {
						prev.R = cur.L;
						cur = null;
						}
						// si es un leave, se elimina como hijo de su padre
						else {
							if(cur.key > prev.key ) 
								prev.R=null;
							else if(cur.key < prev.key)
								prev.L =null;
						cur = null;
						}
						
					} else // Si el subtree o nodo a borrar se encuentra a la izquierda del root
					{
						if (cur.L != null) 
						{
							temp = cur.L;
							
							
							
							if (temp.R != null) 
							{
								Console.WriteLine ("!!!!!!!!!!!!!!!!!!!!1");
								Console.WriteLine (cur.key);
								temp = max (temp.R, ref prev); 
								
								Console.WriteLine ("HERE@FDJFJ " + prev.key);
								Console.WriteLine (temp.key);				
								
								cur.val = temp.val;
								cur.key = temp.key;
									
								// se debe confirmar si tiene derecha o izquierda este nodo //if()	
								if (temp.L!=null) // Si el min tiene hijos a su izquierda
									prev.R = temp.L;
								
								prev.L =null;
								temp = null;
								
								return ;
									
									
								/*
									temp.R = cur.R;
									temp.L = cur.L;
									*/
							}
							else if (temp.L != null) 
							{
							// it must make the temp cur.L?																
							// parent connected to his new right son																						
						
								
							Console.WriteLine("temp.R !!!!!!:" +temp.key);
							// it must make the temp cur.L?																
							// parent connected to his new right son																						
							Console.WriteLine ("!!" + cur.L.key);															
								Console.WriteLine ("V" + cur.L.key);
								
							prev.L = temp;
								
							if(cur.R!=null)
								temp.R = cur.R;
								
							cur = cur.L;
							
							return ;																							
							}	
							
							else if(temp.L==null) // not necessary
							{
								Console.WriteLine("HERE!");
								cur.key = temp.key;
								cur.val = temp.val;
								cur.L=null;
								temp=null;
							}
						
						} 
						// si el nodo a borrar es un leave
						
						// SI a su izquierda no hay nada, hemos llegado a un leave
						
						// si el leave tiene hijos a su derecha, son pasados a su pudre en su izquierda
						
					if(cur.L==null) {
						prev.L = cur.R;
						cur = null;
						}
						else {
						prev.L=null;
						cur = null;
						}
					
				}
			}	
				else if (_key > cur.key) {
				prev = cur;
				cur = cur.R;					
				} else if (_key < cur.key) {
				prev = cur;
				cur = cur.L;
				}
									
			}
		
			
			return ;
			
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



