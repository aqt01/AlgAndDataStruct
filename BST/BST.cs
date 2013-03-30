/*
using System;
using System.Collections.Generic;

namespace BSTTree
{
	
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
		
		
		public int Size ()
		{
			return size;
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
	
		public int rank(int _key)
		{
			// contador
			TreeNode cur = root;
			
			int cnt  = 0;
			bool OT = true; // orientacion del contador, funcionara para indicar cuando el contador es a la derecha o a la izquierda
			
			// si el key introducido es el nodo
			// retorna el size menos la resta de los nodos a la derecha de la raiz menos 1
			
			if (_key == root.key) 
				if(root.L!=null)
					return (root.L.size);
				else
					return size-(root.R.size+1);
			// Si el key es mayor que el root, la orientacion se queda en true, ya que ira a la derecha a buscar por el rank			
			else if(_key > root.key)
				OT = true;
			// Si el key es menor que el root, la orientacion se hace negativa, ya que ira a la izquierda a buscar por el rank						
			else if(_key < root.key)
				OT = false;
			
			while(cur !=null)
				{
					// si encuentra el nodo a calcular
					if(_key == cur.key ) {
						// si se ha encontrado el valor
						// y si se encuentra a su derecha
						
						if(OT) {
							
							// si el nodo posee valores en su derecha e izquierda
							if (cur.R!=null && cur.L!=null) {
								// si el nodo solo posee valor a su derecha
							} else if (cur.R!=null) {
							
								return size -(cnt-cur.size);
							}// si el nodo posee valores en su izq.
							else if (cur.L!=null) {
							
							}// si no posee ningun valor
							else if (cur.R==null && cur.L==null) {
							
							}
						
						} else {
							if (cur.R!=null && cur.L!=null)
							{
								if(cnt == 0)
									return (cur.L.size);
								else if (cnt > 0)									
									return (cur.L.size+cnt);
									
							} else if (cur.R!=null)
							{
							return (cnt );
							}
							else if (cur.L!=null) {
							
							 return (cur.L.size+cnt );
							}
							else if (cur.R==null && cur.L==null) {
							// si el contador no ha recorrido nada
							if(cnt==0)
								return cur.size-1;
							if(cnt>0)
								return cnt;
							
							}
						
						}
					} // a medida que vaya avanzando la busqueda del rank, el contador aumentara +1
					else if(_key> cur.key ) {
						
						if(OT) {
						
						}
						else {
							
							if(cur.L != null)
								cnt += cur.L.size+1 ;
							else if (cur.R!=null && cur.L!=null )
								cnt += cur.L.size; 
							else if(cur.R!=null)
								cnt+= 1;
									
					 	}
						cur = cur.R;
					}
					else if (_key < cur.key )
					{
						
						if(OT) {
							cnt++;
						}
						cur = cur.L;
					}
							
				}
			
			return 0;
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
		
		
		public void printSizes (TreeNode cur)
		{				
			if (cur == null)
				return;
				
			printSizes (cur.R);
			Console.WriteLine ("K: " + cur.key + " SIZE: " +cur.size);									
			printSizes (cur.L);
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
				
			
			//SI se borra el root
			
			
			// Si es menor el key del root, la orienacion de hubbard delete es a la izquierda													
			
			if (_key < cur.key) {		
				OT = false;			
				prev= cur.L;
				cur = cur.L;
			} else if (_key > cur.key) { // Si es mayor el key buscado en comparacion con el root.key, se dirige hacia la derecha
				prev = cur.R;
				cur = cur.R;			
			}	else if (_key == root.key && root.R!=null) {
					prev = cur;					
			}
			else if (_key == root.key && root.L!=null) {
				prev = cur;
				OT= false;
			}
			
				 
			while (cur!=null)
			{
				// Cuando encuentre el valor a eliminar
				// Entra en esa posicion y ademas de eliminar,
				// Busca al sustituto para esa posicion
				//verificar delete cuando no tenga hijos a su izquierda y el de su derecha tenga hijos a su derecha y viceversa
				
				if (cur.key == _key) // Si encuentra el numero a borrar
				{
					
					if (OT) // Si el numero a borrar se encuentra en el subtree a la derecha del root
					{
						if (cur.R != null) { 
							
							temp = cur.R;
							
								
							if (temp.L != null) {
								prev = cur;
							
								//bug cuando min y max no tienen profundidad en sus respectivos lugares a
								temp = min (temp,ref prev); 
								cur.val = temp.val;
								cur.key = temp.key;
								
								if (temp.R!=null) 
								{// Si el min tiene hijos a su derecha
									// guarda esos hijos en la derecha del nodo a reemplazar
									prev.L = temp.R;
									temp = null;
									
								}
								else {// debo hacer el previos de ese min en su izquierda null
									prev.L = null;
									temp = null;
								}
								return ;
									
								
						} else if (cur.R != null) {
							
							// it must make the temp cur.L?																
							// parent connected to his new right son																						
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
						if (cur.L != null) {
							temp = cur.L;						
							
							if (temp.R != null) {
								prev = cur;
								temp = max (temp, ref prev); 
								
								
								cur.val = temp.val;
								cur.key = temp.key;
									
								
								if (temp.L!=null) 
								{// Si el min tiene hijos a su derecha
									// guarda esos hijos en la derecha del nodo a reemplazar
									prev.R = temp.L;
									temp = null;
									
								}
								else {// debo hacer el previos de ese min en su izquierda null
									prev.R = null;
									temp = null;
								}
								
								return ;
									
									
							}
							
							else if (cur.L != null) {
							// it must make the temp cur.L?																
							// parent connected to his new right son																						
						
							// it must make the temp cur.L?																
							// parent connected to his new right son																						
							
							prev.L = temp;
								
							if(cur.R!=null)
								temp.R = cur.R;
								
							cur = cur.L;
							
							return ;																							
							}	
							
							else if(temp.L==null) // not necessary
							{
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
							if(cur.key > prev.key ) 
								prev.R=null;
							else if(cur.key < prev.key)
								prev.L =null;
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
		
			
			
			if(cur.L==null) {
				prev = x;
				return cur;	
				
			}
			
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
			//TreeNode _cur = root;
			
			if(cur.R==null) {
			
				prev = x;
			
				return cur;	
				
			}
	
			
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
	/*	
		
		
		public void AddNode (int _key, int _val)
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
		
			if (root.R!=null && root.L!=null)
			{
				p.Push(root.L);
				p.Push(root.R);
			} else if (root.R!=null )
				p.Push(root.R);
			else if(root.L!=null )
				p.Push(root.L);
			
			p.Push(root);
			
			while (curr!=null) {		
				
				temp = curr;
				
				if(_key == curr.key)
				{
					curr.key = _key;
					curr.val = _val;
					return ;
				}					
				else if (_key < curr.key)
				{
					p.Push(curr);	
					curr = curr.L;																
				
				}
				else if (_key > curr.key)
				{						
					p.Push(curr);
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
			
			TreeNode tm = null;
			
			
			for(int i=0 ; i<=p.Count;i++)		
			{
						tm = p.Pop();
						updateSize(ref tm);
						
			}
			// incrementa el tamanio del tree
			// 
			size++;
			root.size = size;
		}
		
		
		
		public void updateSize(ref TreeNode x) 
		{
			// Si el nodo posee 	
			if(x.R!=null && x.L !=null)
			{
				x.size = x.R.size+x.L.size+1;
				
			} else if( x.L!=null)
			{	
				x.size = x.L.size+1;
			} else if (x.R !=null) {
				x.size = x.R.size+1;
			}
			
			
		}
		
		// agrega un nodo sin sizes
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
*/