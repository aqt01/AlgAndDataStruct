using System;
using System.Collections.Generic;

namespace BSTTree
{
    public class MainClass
	{
		public static void Main ()
		{ 	
			BST bst = new BST();
			// Se inserta una enormemente ridicula cantidad de datos	
			bst.AddNode (10, 1);
			bst.AddNode (20, 3);
			bst.AddNode (15, 4);
			bst.AddNode (25, 5);
			bst.AddNode (30, 6);
			bst.AddNode (14, 8);
			bst.AddNode (17, 9);
			bst.AddNode (16, 10);
			bst.AddNode (18, 11);
			bst.AddNode (19, 12);
			bst.AddNode (40, 1);
			bst.AddNode (5, 13);
			bst.AddNode (4, 14);
			bst.AddNode (8, 15);
			bst.AddNode (9, 16);
			bst.AddNode (7, 17);
			bst.AddNode (1, 13);
			bst.AddNode (3, 14);
			bst.AddNode (2, 15);
			bst.AddNode (22, 1);
			bst.AddNode (21, 3);
			bst.AddNode (24, 5);
			bst.AddNode (23, 4);
			bst.AddNode (35, 1);
			bst.AddNode (31, 3);
			bst.AddNode (37, 4);
			bst.AddNode (38, 5);
			bst.AddNode (50, 5);
			bst.AddNode (60, 5);
			bst.DeleteNode(20);
			bst.printSizes();
	
		}
	}

	public class BST
	{
		public static double w  = 1+Math.Sqrt(2);
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

	
	// se toma el padre F que es el padre de la rotacion, 
	//y el rot, que sera el nodo a rotar	
	
	public void rotateLeft(TreeNode F, TreeNode P)
	{
			
		// si el numero a rotar recibido es nulo, devuelve una excepcion
    	if(P == null)        
	    	throw new InvalidRotationException("You cannot rotate an empty Tree!");
		// Si el hijo derecho del nodo a rotar es nulo, sale de la funcion, ya que no se puede rotar
		if(P.R==null)
			return ;
		
		// Estas asignaciones se hacen para tener una mejor abstraccion
		TreeNode A = P.L;
    	TreeNode Q = P.R;
    	TreeNode B = Q.L;
    	TreeNode C = Q.R;	
	
		
		P.R=B;
		Q.L = P;
					
		if(P.key==root.key) {
    	// si posee padre    	
			// reubica la posicion del hijo con relacion a su padre			
       	
			//Q->P = NULL;
			root=Q;
    	}
    	else if(F!=null) // si no es 
    	{
       		if(F.R == P)
				F.R = Q;
			else if (F.L == P)
				F.L = Q;
    	} else if(F==null)
			root = Q;
		
		
	// Se actualizan todos los tamanios de los nodos que fueron insertados
	// Se actualizan de abajo hacia arriba
		if(A!=null)
			updateSize(ref A);
		if(B!=null)
			updateSize(ref B);
		if(P!=null)
			updateSize(ref P);
		if(C!=null)
			updateSize(ref C);
		if(Q!=null)
			updateSize(ref Q);
		if(F!=null)
			updateSize(ref F);

	}	

	public void rotateRight(TreeNode F, TreeNode Q)
	{
		// Error al rotar un valor invalido
		if(Q==null)
			throw new InvalidRotationException("You cannot rotate an empty node!");
	
		if(Q.L==null)
			//throw new InvalidRotationException("You cannot rotate an empty node!");
			return ;				
				
		TreeNode P =  Q.L;
		TreeNode C = Q.R;
		TreeNode B = P.R;
		TreeNode A =  P.L;
					
		Q.L = P.R;
		P.R= Q;
		
		// Si el nodo a rotar es la raiz del arbol
		// iguala la raiz al hijo izquierdo del nodo a rotar
		if(Q.key==root.key)
    	{			
			root=P;
    	}
    	else if (F!=null) // si posee padre
    	{
			// reubica la posicion del hijo con relacion a su padre			
       		if(F.R == Q)
				F.R = P;
			else if (F.L == Q)
				F.L = P;
    	} else if (F==null) // si el padre es nulo,
			root =P;
		
		// Se actualizan los tamanios de los nodos movidos
			
		if(B!=null)
			updateSize(ref B);
		if (Q.L!=null)
			updateSize(ref Q.L);
		if(C!=null)
			updateSize(ref C); 
		if(Q!=null)
			updateSize(ref Q);
		if(A!=null)
			updateSize(ref A);
		if(P!=null)
			updateSize(ref P);
		if (F!=null)
			updateSize(ref F);

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
			if(_key> cur.key ) {

				if(OT) {
					if(cur.L != null)
						cnt += cur.L.size+1 ;
					else if (cur.R!=null && cur.L!=null )
						cnt += cur.L.size; 
					else if(cur.R!=null)
						cnt+= 1;	
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
				cur = cur.L;
				} else
			{
				if(OT) {
					// si el nodo posee valores en su derecha e izquierda
					if (cur.R!=null && cur.L!=null) {
						return (cnt+cur.L.size);
						// si el nodo solo posee valor a su derecha
					} else if (cur.R!=null) {
							// retorna el acumulado de sizes por el contador
						return (cnt);
					}// si el nodo posee valores en su izq.
					else if (cur.L!=null) {
					//retorna el contador de sizes + los tamanios izquierdos del nodo
					// presente
						return (cnt+cur.L.size);
					}// si no posee ningun valor
							// retorna la cantidad de los sizes acumulados
					else if (cur.R==null && cur.L==null) {
						return cnt;
					}

				} else {
					if (cur.R!=null && cur.L!=null) {
						if(cnt == 0)
							return (cur.L.size);
						else if (cnt > 0)	
							return (cur.L.size+cnt);	
						} else if (cur.R!=null) {
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
			}
	}
	// si no se ha encontrado el valor
	// devuelve el supuesto rankid que deberia tener si estuviese
	return cnt;
	}	
    // Funcion select    
    public int Select(int nth_el)
    {	
		TreeNode cur = root; 
		int rankid=0; // Rankid
		int cnt  = 0; // Contador 
		bool OT = true; // orientacion del contador, funcionara para indicar cuando el contador es a la derecha o a la izquierda
			
     	// si la raiz posee a su derecha un subarbol    
		// si el nth_el buscado es igual al rank del root, lo devuelve
		if (nth_el ==  (size-(root.R.size+1)) )
        	return (root.key);
		
		if(root.R!=null) 
			// si es mayor el nth_el que el rank del root, 
			// la orientacion cambia a la derecha y guarda el rank en rankid
			
        	if (nth_el >  (size-(root.R.size+1)) ) {
        	OT = true;                    
			rankid = size-(root.R.size+1);
			}
			// si es menor el nth_el que el rank del root, 
			// la orientacion cambia a la izquierda y guarda el rank en rankid		
       		else if (nth_el <  (size-(root.R.size+1)) ) {
        	OT = false;                    
			rankid =  size-(root.R.size+1);
			}
        	// si no posee a su derecha raiz
			else // devuelve el root  si es numero buscado es el rank buscado
    			if ( nth_el >  (root.L.size) ) {
 	    	    	rankid = root.L.size;
					OT = true;    
				}
      		else if ( nth_el <  (root.L.size) )	{
            	rankid = root.L.size;
				OT = false;
			}
		
	
			// Si el key es mayor que el root, la orientacion se queda en true, ya que ira a la derecha a buscar por el rank	
			while(cur !=null)
			{
				// Calcula el rank-id de esta posicion en el arreglo 
				// y verifica si es igual al elemento buscado
				
				if(OT) {

				// si el nodo posee valores en su derecha e izquierda
	    		if (cur.R!=null && cur.L!=null) {
	        		if (nth_el== (cnt+cur.L.size) )
            			return cur.key;
					rankid= (cnt+cur.L.size);
    				// si el nodo solo posee valor a su derecha
	    			} else if (cur.R!=null) {
	        			if (nth_el==cnt)
                			return cur.key;
					rankid = cnt;
	    			}// si el nodo posee valores en su izq.
					else if (cur.L!=null) {
	    				if (nth_el == (cnt+cur.L.size) )
        					return cur.key;
						rankid = (cnt+cur.L.size);
						}// si no posee ningun valor
						else if (cur.R==null && cur.L==null) {
	    					if(nth_el == cnt)
            					return cur.key;
	    					rankid = (cnt);
							}		
				} else {// si la orientacion es hacia la izquierda
				// recalcula todos los rankid para la posicion del cur
				// de acuerdo a las condiciones de abajo
				if (cur.R!=null && cur.L!=null)	{
					if(cnt == 0) {
	    				if(nth_el==cur.L.size)
            				return (cur.key);
						rankid = cur.L.size;
					}
					else if (cnt > 0)	{
	    				if (nth_el == (cur.L.size+cnt) )
            				return (cur.key);
						rankid = (cur.L.size+cnt);
					} 
					} else if (cur.R!=null)	{
	    				if(nth_el ==cnt )	
        					return (cur.key);			
						rankid = cnt;
					}
						
					else if (cur.L!=null) {
	    				if(nth_el == cur.L.size+cnt ) 		
        					return cur.key;
						rankid = cur.L.size+cnt;		
					}
					else if (cur.R==null && cur.L==null) {
					// si el contador no ha recorrido nada
						if(cnt==0)	{
							if( nth_el ==cur.size-1)
    	    					return cur.key;
							rankid = cur.size-1;
						}
						if(cnt>0)	{
							if (nth_el==cnt)
        						return cur.key;
							rankid = cnt;
						}

					}

			}
			// Al momento de calcular los rankid arriba de las posiciones
			// y de no haberse cumplido que sean iguales al elemento buscado
			// se toma el rankid de esa posicion para buscar el elemento	
			if(nth_el > rankid ) {

	    	if(OT) {
	        	if(cur.L != null)
	            	cnt += cur.L.size+1 ;
	        	else if (cur.R!=null && cur.L!=null )
		            cnt += cur.L.size; 
		        else if(cur.R!=null)
	    	        cnt+= 1;	
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
		else if (nth_el < rankid )
		{
 	       cur = cur.L;
		}

	
	}
	
	// Devuelve Excepcion si no ha encontrado el valor
	throw new KeyNotFoundException();
	        

	}

        
	public int Find (int _key)
	{
	// Si el arbol esta vacio, lanza una excepcion
		if (root == null)
			throw new EmptyTreeException("You cannot find a key in an empty Tree! ");

		TreeNode cur = root;

	// itera hasta encontrar el valor introducido

		while (cur!=null) {

			if (cur.key == _key)
				return cur.val;
			else if (_key > cur.key)
				cur = cur.R;
			else if (_key < cur.key)
				cur = cur.L;

		}
	// Si no encuentra el valor, lanza excepcion de keynotfound

		throw new KeyNotFoundException();


	}


	public int nodeSize(TreeNode x)
	{
		return x.size;
	}

	public int min_Size(TreeNode x) 
	{
		if(x.R!=null && x.L!=null)		
			{
				
				if(x.R.size > x.L.size)
					return x.L.size;
				else
					return x.R.size;				
			}
			else 
			{
				
			
				if(x.R!=null)
					return x.R.size;
				else if(x.L!=null)
					return x.L.size;	
			}
		
		return 0; // si no posee hijos, devuelve 0
		}

	public int max_Size(TreeNode x) 
		{
		if(x.R !=null && x.L!=null) 
			{
			if(x.R.size > x.L.size)
				return x.R.size;
			else
				return x.L.size;
		} else 
			{
			if(x.R!=null)
				return x.R.size;
			else if(x.L!=null)
				return x.L.size;
		}	
			return 0; // si no posee hijos, devuelve 0
		}

	public double balance_Factor(TreeNode X) 
		{
		if(X.R!=null && X.L!=null)
			return (  max_Size(X.R)/( (min_Size(X.L)+1)) );
		else
			if(X.R!=null)
				return X.R.size;
			else if (X.L!=null)
				return X.L.size;
		return 0;
	}

	//Wrapper para imprimir todos los sizes
	public void printSizes ()
	{
		printSizes(root);
		}
	// Imprime todos los valores junto con sus tamanios

	public void printSizes (TreeNode cur)
	{	
		if (cur == null)
			return ;
		if(root == null)
			throw  new EmptyTreeException("You cannot erase in an Empty Tree!");
		printSizes (cur.R);
		Console.WriteLine("KEY: " +cur.key + " SIZE: "+ cur.size);					
		printSizes (cur.L);
	}
	// Imprime todos los valores

	public void print ()
	{	
		print(root);
	}

	public void print (TreeNode cur)
	{	
		if (cur == null)
			return ;
		if(root == null)
			throw  new EmptyTreeException("You cannot erase in an Empty Tree!");

		print (cur.R);        	
		Console.WriteLine("KEY: " +cur.key);							
		print (cur.L);
	}

	// actualiza todos los nodos
	public void updateAll ()
	{	
		updateAll(root);
	}

	public void updateAll (TreeNode cur)
	{	
		if (cur == null)
			return ;
		if(root == null)
			throw  new EmptyTreeException("You cannot update in an Empty Tree!");

		updateAll (cur.R);        	
		updateSize(ref cur);	
		updateAll (cur.L);
	}


	public void DeleteNode (int _key)
	{
		// Nodo para buscar el valor a eliminar
		TreeNode cur = root;
		// Nodo temporal
		TreeNode temp = null;
		// Nodo anterior al nodo a borrar, o nodo usado para reconectar el arbol
		TreeNode prev = null;

		if (root == null) // si borras un arbol vacio tira excepcion
			throw  new EmptyTreeException("You cannot erase in an Empty Tree!");

		// OT es la orientacion que tomara el hubbards delete
		// True: derecha, false: izquierda
		bool OT = true;
		int keyToDel = 0; //key a borrar, usado para verificar 
						// la direccion de las rotaciones al final


		// Si es menor el key del root, la orienacion de hubbard delete es a la izquierda	

		if (_key < cur.key) {	// SI el nodo es menor que el key, se dirige hacia la izquierda
		// OT toma valor falso, indicando que los valores a buscar de
		// ahora en adelante seran a la izquierda
			OT = false;	
			prev= cur.L;
			cur = cur.L;
		} else if (_key > cur.key) { // Si es mayor el key buscado en comparacion con el root.key, se dirige hacia la derecha
			prev = cur.R;
			cur = cur.R;	
		// SI el valor se encuentra en la raiz, y si la raiz posee hijos a su derecha

		}	else if (_key == root.key && root.R!=null) {
		// se guarda en prev el valor de la raiz
			prev = cur;	
		} // si el valor a eliminar es la raiz y solo posee hijos izquierdos
		// prev es root y la orientacion cambia a la izquierda
		else if (_key == root.key && root.L!=null) {
			prev = cur;
			OT= false;
		}

	// Stack usado para guardar los valores al momento de navegar
	// y buscar al nodo a borrar, con el fin de actualizar sus sizes

			Stack<TreeNode> p = new Stack<TreeNode>();
	
			p.Push(root);

		while (cur!=null)
		{
		// Cuando encuentre el valor a eliminar
		// Entra en esa posicion y ademas de eliminar,
		// Busca al sustituto para esa posicion

				if (cur.key == _key) // Si encuentra el numero a borrar
				{	// se guarda la llave a borrar como el key del cur encontrado
			 		keyToDel = cur.key ;
		
				if (OT) // Si el numero a borrar se encuentra en el subtree a la derecha del root
				{	// Si el numero a borrar posee valores a su derecha
					if (cur.R != null) { 
				// mueve el temporal a su derecha
						temp = cur.R;

				// si el nodo a borrar hacia la derecha, posee hijos a su izwquierda

						if (temp.L != null) {
									
							prev = cur;
				
							temp = min (temp,ref prev); 
							cur.val = temp.val;
							cur.key = temp.key;

							if (temp.R!=null) {
							// Si el min tiene hijos a su derecha
							// guarda esos hijos en la derecha del nodo a reemplazar
								prev.L = temp.R;
								temp = null;
							}
							else {
								// debo hacer el previos de ese min en su izquierda null
								prev.L = null;
								temp = null;
							}
						}
						else if (cur.R != null) {
								
							prev.R = temp;

							if(cur.L!=null)	{
								temp.L = cur.L;
							}
							cur = cur.R;
						}

					// Caso en que no posea a la derecha
					// Si no posee hijos a la izquierda ni a la derecha
						else if(temp.R==null) {
						// not necessary
							cur.key = temp.key;
							cur.val = temp.val;
							cur.R=null;
							temp=null;
					}
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

			} 
			else // Si el subtree o nodo a borrar se encuentra a la izquierda del root
			{
				if (cur.L != null) {
					temp = cur.L;	

				if (temp.R != null) {
					prev = cur;
					temp = max (temp, ref prev); 
					cur.val = temp.val;
					cur.key = temp.key;

						if (temp.L!=null) {
							// Si el min tiene hijos a su derecha
							// guarda esos hijos en la derecha del nodo a reemplazar
							prev.R = temp.L;
							temp = null;
						}
						else {// debo hacer el previos de ese min en su izquierda null
					
							prev.R = null;
							temp = null;
						}	

				}	
				else if (cur.L != null) {
					prev.L = temp;
						if(cur.R!=null)
							temp.R = cur.R;
					cur = cur.L;
						
				}	
	
				else if(temp.L==null) // not necessary
				{
					cur.key = temp.key;
					cur.val = temp.val;
					cur.L=null;
					temp=null;
				}

			} 
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
			size--;
			// upd sera el nodo que representara los nodos 
			// recorridos para actualizar sus 'sizes'
			TreeNode upd = new TreeNode();
			// se actualizan todos los nodos guardados
			// F representara los padres de los nodos recorridos
			TreeNode F = new TreeNode();
			for(; p.Count != 0;)	
			{
				upd = p.Pop();
				upd.size--;
				updateSize(ref upd.R);
				updateSize(ref upd.L);
				updateSize(ref upd);
					if ( balance_Factor(upd) > w)
					{	// si la insercion fue a la derecha
					// rota a la izquierda
					
						if(_key > keyToDel)
						{
							// si el nodo a rotar, no es root, tendra padre
							if(p.Count!=0)
								F = p.Pop(); // padre de TM, usado para las rotaciones						
							else // si es root
								F = null;
						
							rotateRight(F,upd); //vice versa
							if(p.Count!=0)
								p.Push(F); // vuelve a insertar para seguir actualizando. 
									// siempre y cuando el valor sacado no sea root		
						}
						else if (_key < keyToDel)
						{
							if(p.Count!=0)
								F = p.Pop(); // padre de TM, usado para las rotaciones						
							else // si es root
								F = null;
						
							rotateLeft(F,upd);
							if(p.Count!=0)
								p.Push(F);
						}
					
				}
		}

		} // si aun no se ha encontrado el nodo a borrar, continua buscando	
		else if (_key > cur.key) 
		{	 // en cada busqueda se almacena el padre del anterior, para luego actualizar los nodos guardados
			prev = cur;	
			p.Push(cur);
			cur = cur.R;	
		} else if (_key < cur.key) {	
			p.Push(cur);	  	 	  
			prev = cur;
			cur = cur.L;
		}

	}


	return ;

	}

	// busca el ultimo nodo hacia la izquierda
	protected TreeNode min (TreeNode x, ref TreeNode prev)
	{
		TreeNode cur = x;
	if(cur.L==null) {
		prev = x;
		return cur;	
	}

	while (cur.L!=null) {
		prev = cur;
		cur = cur.L;
	}


	return cur;
	}

	// busca el ultimo nodo hacia la derecha
	protected TreeNode max (TreeNode x, ref TreeNode  prev)	{
	
		TreeNode cur = x;
	
		if(cur.R==null) {	
			prev = x;
			return cur;	
		}


	while (cur.R!=null) { 	
		prev = cur;
		cur = cur.R;
	}
	return cur;
	}




	public void AddNode(int _key, int _val)	{
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


			size++; // se incrementa el tamanio del tree
		// en tm se guardan todos los nodos recorridos y se actualizan
			TreeNode tm = new TreeNode();
			TreeNode F = new TreeNode(); // F sera padre de TM
		for( ; p.Count!=0;)	
		{
			tm = p.Pop();
			
			updateSize(ref tm.R);
			updateSize(ref tm.L);
			updateSize(ref tm);
				
			// si su balance factor es mayor que la constante definidia
			// w=1+sqrt(3)		
			// rota el nodo
			if ( balance_Factor(tm) > w)
				{	// si la insercion fue a la derecha
					// rota a la izquierda
					
					if(_key > temp.key)
					{
						// si el nodo a rotar, no es root, tendra padre
						if(p.Count!=0)
							F = p.Pop(); // padre de TM, usado para las rotaciones						
						else // si es root
							F = null;
						
						rotateLeft(F,tm); //vice versa
						if(p.Count!=0)
							p.Push(F); // vuelve a insertar para seguir actualizando. 
									// siempre y cuando el valor sacado no sea root
						
					}
					else if (_key < temp.key)
					{
						if(p.Count!=0)
							F = p.Pop(); // padre de TM, usado para las rotaciones						
						else // si es root
							F = null;
						
						rotateRight(F,tm);
						if(p.Count!=0)
							p.Push(F);
					}
					updateSize(ref tm.R);
					updateSize(ref tm.L);
					updateSize(ref tm);
				}
					
		}

	}


	public void updateSize(ref TreeNode x)	{

		if(x==null)
			return;	
		//Actualiza dos hijos
		if(x.R!=null && x.L !=null)
		{
			x.size = x.R.size+x.L.size+1;	
		} else if( x.L!=null) { // actualiza hijo izquierdo 	
			x.size = x.L.size+1;
		} else if (x.R !=null) {//actualiza hijo derecho
			x.size = x.R.size+1;
		}//actualiza tamanio del root
		root.size = size;
	}

	// agrega un nodo sin sizes
	}

	public class TreeNode
	{

		public TreeNode L, R	;	// parent, right and left
		//public TreeNode P;
		public int val;
		public int key;
		public int size; // subtree size

		public TreeNode (int _key, int _val)
		{	
		L = null;
		R = null;	
		
		key = _key;
		val = _val;
		size=1;
		}
		public TreeNode ()
		{
			L = null;
			R = null;
		
		}

	}
	
	// Excepciones
	// Excepcion para operaciones con arbol vacio
	public class EmptyTreeException : System.Exception
	{
    //Constructors. It is recommended that at least all the
    //constructors of
    //base class Exception are implemented
    	public EmptyTreeException() : base() { }
		public EmptyTreeException(string message) : base(message) { }
    	public EmptyTreeException(string message, Exception e) : base(message, e) { }
    //If there is extra error information that needs to be captured
    //create properties for them.
    	private string strExtraInfo;
    	public string ExtraErrorInfo 
    	{ 
    	get { return strExtraInfo;  }
        set { strExtraInfo = value; }
    	}
	}
	// Excepcion en caso de que se reciba un valor nulo a rotar
	public class InvalidRotationException : System.Exception
	{
    	public InvalidRotationException() : base() { }
    	public InvalidRotationException(string message) : base(message) { }
    	public InvalidRotationException(string message, Exception e) : base(message, e) { }
    	//If there is extra error information that needs to be captured
    	//create properties for them.
    	private string strExtraInfo;
    	public string ExtraErrorInfo
    	{
        	get { 	return strExtraInfo; 	}
        	set {	strExtraInfo = value;	}
    	}
	}
	
	
}

