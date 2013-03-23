
using System;

namespace BSTTree
{
	
	public class MainClass
	{
		public static void Main() 
		{
			BST bst = new BST();
			/*
			bst.AddNode(1,1);
			bst.AddNode(2,3);
			bst.AddNode(3,3);
			*/
			
			bst.AddNode(10,1);
			bst.AddNode(20,3);
			bst.AddNode(15,4);
			bst.AddNode(25,5);
			bst.AddNode(30,6);
			bst.AddNode(15,7);
			bst.AddNode(14,8);
			bst.AddNode(17,9);
			bst.AddNode(16,10);
			bst.AddNode(18,11);
			bst.AddNode(19,12);
			
			// 30 more
			
			bst.AddNode(40,1);
			
			bst.AddNode(5,13);
			bst.AddNode(4,14);
			bst.AddNode(8,15);
			bst.AddNode(9,16);
			bst.AddNode(7,17);
						
			
			bst.print(bst.getRoot());
			Console.WriteLine(bst.max(bst.getRoot()).key);			
			Console.WriteLine(bst.min(bst.getRoot()).key);
			// Must implemnet an stack
			//Console.WriteLine(bst.next(1).key);			
			
			
			
			Console.WriteLine(bst.DeleteNode(25));
			
			Console.WriteLine(bst.DeleteNode(30));
			Console.WriteLine("After 25 delete");
			
			bst.print(bst.getRoot());
			Console.WriteLine(bst.FindNode(20).R.key);
			 
									
		}
	}
	
	public class BST
	{

			int size;
			TreeNode root;
			
			public BST() 
			{			
				root = null;
				size=0;
			}			
			
			public TreeNode getRoot() 
			{
				return root;
			}		
		
			//Iteracion
			// Pendiente
		/*
			public void printAll() 
			{	
				int max = root.key;
				TreeNode cur = root;
				
				Stack<TreeNode> S = new Stack<TreeNode>();
			
			
				if(root == null)
					return ;
			
				
				
				while(true)
				{	
					while(cur!=null)
					{
						S.push(cur);
						cur=cur.L;
						if(max<cur)
							max = cur.key;
						
					}
				}								

				if(S.Count==0) break;				
				S.pop(cur);
				cur = cur.key;
				
				
				cur = cur.R;
				
				S.push(cur.L);
			}
	
			/*		
		}
				else
				{
				Console.Writeline("ken = {0} value={1}", cur.key, cur.value);
				S.pop();
				if(cur.R!=null)	
					S.push(cur.R);			
				}*/
		
			
		
			//Hubbard's Delete
		
		
			public TreeNode FindNode(int _key) 
			{
				
				if(root==null)
					return null;
			
				TreeNode cur = root;
			
				while(cur!=null)
				{
					
					if(cur.key ==_key)
						return cur;
					else if(_key > cur.key)
						cur=cur.R;					
					else if (_key < cur.key)
						cur=cur.L;
									
				}
			
				return null;
				
					
			}
		
			public int Find(int _key) 
			{
				
				if(root==null)
					return -1;
			
				TreeNode cur = root;
			
				while(cur!=null)
				{
					
					if(cur.key ==_key)
						return cur.val;
					else if(_key > cur.key)
						cur=cur.R;					
					else if (_key < cur.key)
						cur=cur.L;
									
				}
			
				return -1;
				
					
			}
		
			
		
			public void print (TreeNode cur)
			{				
        		if(cur==null)
                	return;
				
        		print(cur.R);        		
				Console.WriteLine(cur.key);									
        		print(cur.L);
			}
    
		
			public TreeNode DeleteNode(int _key) 
			{
				// Node to delete
				TreeNode cur = root;
				// Node to seek
				TreeNode temp = null;
				
				TreeNode prev = null;
				
				if(cur==null)
					return null;
			
				// OT es la orientacion que tomara el hubbards delete
				// True: derecha, false: izquierda
				bool OT= true;
				
				// Si es menor el key del root, la orienacion de hubbard delete es a la izquierda
				
				if(_key<cur.key)
				{		
					OT=false;				
					cur=cur.L;
				}			
				
				else if(_key>cur.key) // Si es mayor el key buscado en comparacion con el root.key, se dirige hacia la derecha
					cur = cur.R;				
					
				 
				while(cur!=null)
				{
					// Cuando encuentre el valor a eliminar
					// Entra en esa posicion y ademas de eliminar,
					// Busca al sustituto para esa posicion
				
					if(cur.key ==_key) 
					{
						if(OT) 
						{
							if(cur.L!=null) 
							{
								temp = cur.L;
							
								if(temp.R!=null) 
								{
								
									Console.WriteLine (temp.key);
									temp = max(temp.R); 
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
							} else if(cur.R!=null)
							{
								// it must make the temp cur.L?
								
								
								// parent connected to his new right son
								
								
								
								Console.WriteLine ("!" + cur.R.key);
								
								
								cur = cur.R;
								prev.R = cur;
							 	
								
								/*
								cur.L = temp.L;
								cur.R = temp.R;
								cur = temp;
								*/
							}
						
									
							return cur;
						
						} else 
						{
							
							return cur;
						
						}
					}
					
					else if(_key > cur.key)
					{
						prev = cur;
						cur=cur.R;					
					}
					else if(_key < cur.key)
					{
						prev = cur;
						cur=cur.L;
					}
									
				}
			
				return null;
				
				
				
				
			}	
		
			
			
		
			public TreeNode min(TreeNode x) 
			{

				TreeNode cur = x;
				//TreeNode _cur = root;

				while (cur.L!=null)
				{
					cur = cur.L;
				}
				return cur;
			}
			
			public TreeNode next(int _key) 
			{	
				TreeNode best = null;
				TreeNode cur = root;
	
				if(root==null)
					return null;
			
					while(cur!=null) 
					{
	
						if(_key>cur.key) 
						{
							cur = cur.R;
						}
						else
						{
							best = cur;
							cur = cur.R;
						}
	
					}
			
				return best;	
			}
		
			public TreeNode max(TreeNode x) 
			{

				TreeNode cur = x;

				while (cur.R!=null)
				{ 	
					cur = cur.R;
				}
				return cur;
			}
		
			public void AddNode(int _key , int _val) 
			{
								
				TreeNode newNode = new TreeNode(_key,_val);			
				TreeNode curr = root;
				TreeNode temp = null;
										
				if(size==0) 
				{		
					root = newNode;
					size++;
					return ;
				}
				
				
				while (curr!=null)
				{		
				
				//	temp = curr;	
					temp = curr;
					// Si el valor ya existe, reemplaza el valor del nodo
					if (_key == curr.key) 
					{
						curr.val  = _val;
						return ;
					}
					
					if(_key < curr.key )
						
						curr = curr.L;
					else if (_key > curr.key)
						
						curr = curr.R;
				
				
				
				}	
			
					
				if(_key > temp.key)
				{ 
					curr = new TreeNode(_key,_val);
					temp.R = curr;
				} else if (_key < temp.key) 
				{
					curr = new TreeNode(_key,_val);
					temp.L = curr;
				}
				
				
			
				size++;
					
			
				}
			}
		
			public class TreeNode 
			{
		
				public TreeNode L,R	;			// parent, right and left
				public TreeNode P;
				public int val;
				public int key;
		
			
			public TreeNode(int _key , int _val) 
			{	
				L = null;
				R = null;		
				P = null;
				key = _key;
				val = _val;
			}
			
			// Think this is not necessary
			
			public TreeNode()
			{
				L=null;
				R=null;
				P=null;
			}
			
			
		}
	}


