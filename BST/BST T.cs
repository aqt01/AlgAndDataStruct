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
			bst.AddNodeB(1,1);
			bst.AddNodeB(2,3);
			bst.AddNodeB(3,3);
			*/
			// FINE WITH SIZES
			/*
			bst.AddNodeB (10, 1);
			bst.AddNodeB (13, 1);
			bst.AddNodeB (5, 3);
			bst.AddNodeB (3, 4);
			bst.AddNodeB (4, 5);
			bst.AddNodeB (1, 6);
			bst.AddNodeB (2, 7);
			*/
			
			bst.AddNodeB (18, 1);
			bst.AddNodeB (12, 1);
			bst.AddNodeB (22, 3);
			
			bst.AddNodeB (10, 4);
			bst.AddNodeB (13, 5);
			bst.AddNodeB (16, 5);
			bst.AddNodeB (15, 6);
			bst.AddNodeB (14, 6);
			bst.AddNodeB (17, 6);
			
			bst.AddNodeB (29, 6);
			bst.AddNodeB (5, 7);
			
			bst.AddNodeB (11, 5);
			
			bst.AddNodeB (35, 7);
			
			bst.AddNodeB (4, 5);
			bst.AddNodeB (7, 6);
			bst.AddNodeB (2, 7);
			
			bst.AddNodeB (6, 6);
			bst.AddNodeB (9, 7);
			bst.AddNodeB (8, 7);
			
			bst.AddNodeB (24, 1);
			bst.AddNodeB (27, 1);
			bst.AddNodeB (23, 3);
			bst.AddNodeB (25, 1);
			bst.AddNodeB (28, 1);
			
			Console.WriteLine("RNK = " + bst.rank(13 ));
			Console.WriteLine("RNK = " + bst.rank(14 ));
			Console.WriteLine("RNK = " + bst.rank(15 ));
			
			
			Console.WriteLine("16 RNK = " + bst.rank(16 ));
			Console.WriteLine("17 RNK = " + bst.rank(17 ));
			
			Console.WriteLine("18 RNK = " + bst.rank(18 ));
			Console.WriteLine("RNK = " + bst.rank(15 ));
			
			
			
			Console.WriteLine("RNK = " + bst.rank(2 ));
			Console.WriteLine("RNK = " + bst.rank(4 ));
			Console.WriteLine("RNK = " + bst.rank(7 ));
			Console.WriteLine("RNK = " + bst.rank(9 ));
			
			Console.WriteLine("22 RNK = " + bst.rank(22 ));
			Console.WriteLine("29 RNK = " + bst.rank(29 ));
			Console.WriteLine("35 RNK = " + bst.rank(35 ));
			
			
			Console.WriteLine("24 RNK = " + bst.rank(24 ));
			Console.WriteLine("23 RNK = " + bst.rank(23 ));
			Console.WriteLine("25 RNK = " + bst.rank(25 ));			
			Console.WriteLine("27 RNK = " + bst.rank(27 ));
			Console.WriteLine("28 RNK = " + bst.rank(28 ));
			
			
			bst.printSizes(bst.getRoot());
			bst.print(bst.getRoot());
			
			
			/*	
			
			bst.AddNodeB (10, 1);
			bst.AddNodeB (20, 3);
			bst.AddNodeB (15, 4);
			bst.AddNodeB (25, 5);
			bst.AddNodeB (30, 6);
			//bst.AddNodeB (15, 7);
			bst.AddNodeB (14, 8);
			bst.AddNodeB (17, 9);
			bst.AddNodeB (16, 10);
			bst.AddNodeB (18, 11);
			bst.AddNodeB (19, 12);
			
			// 30 more
			
			bst.AddNode (40, 1);
			
			bst.AddNodeB (5, 13);
			bst.AddNodeB (4, 14);
			bst.AddNodeB (8, 15);
			bst.AddNodeB (9, 16);
			bst.AddNodeB (7, 17);

			bst.AddNodeB (1, 13);
			bst.AddNodeB (3, 14);
			bst.AddNodeB (2, 15);
			
			
			// another more
		
			 
			bst.AddNodeB (22, 1);
			bst.AddNodeB (21, 3);
			bst.AddNodeB (24, 5);
		
			bst.AddNodeB (23, 4);
		
			
			bst.AddNodeB (35, 1);
			bst.AddNodeB (31, 3);
			bst.AddNodeB (37, 4);
			bst.AddNodeB (38, 5);
			
			bst.AddNodeB (50, 5);
			bst.AddNodeB (60, 5);
			
			TreeNode tm = bst.FindNode(20);
			
			*/
			// without sizes
			/*
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
			
			
			// another more
		
			 
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
			
			*/
			
			//Console.WriteLine (bst.max (bst.getRoot ()).key);			
			//Console.WriteLine (bst.min (bst.getRoot ()).key);
			// Must implemnet an stack
			//Console.WriteLine(bst.next(1).key);			
			
			
			
			/*
			//Deleting root and checkin left wind
			bst.DeleteNode(10);
			
			Console.WriteLine ("After 10 delete");
			bst.print (bst.getRoot ());
			
			Console.WriteLine (" Root:  " + bst.getRoot().key);
			Console.WriteLine ("Root L:  " + bst.getRoot().L.key);
			
			//Console.WriteLine ("Root L R:  " + bst.getRoot().L.R.key);
			Console.WriteLine ("Root L L:  " + bst.getRoot().L.L.key);
			Console.WriteLine ("Root L L R:  " + bst.getRoot().L.L.R.key);
			
			
			*/
			
			
			// DEleting the root
			/*
			bst.DeleteNode(10);
			
			Console.WriteLine ("After 40 delete");
			bst.print (bst.getRoot ());
			
			Console.WriteLine (" Root:  " + bst.getRoot().key);
			Console.WriteLine ("Root L:  " + bst.getRoot().L.key);
			Console.WriteLine ("Root L L:  " + bst.getRoot().L.L.key);
			Console.WriteLine ("Root R:  " + bst.getRoot().R.key);
			Console.WriteLine ("Root R R:  " + bst.getRoot().R.R.key);
			
			Console.WriteLine ("Root R:  " + bst.getRoot().R.key);
			Console.WriteLine ("Root R L:  " + bst.getRoot().R.L.key);
			*/
			
			// must blow up
			//Console.WriteLine(" 3 L R: " + bst.FindNode(3).L.R.L.key);
			
			//Console.WriteLine(" 3 L R: " + bst.FindNode(3).L.R.R.key);
			
			
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
			
			// plus more sons
			/*
			bst.DeleteNode (21);
			Console.WriteLine("DELETING 20!!!!!");
			bst.DeleteNode (20);
			
			
			
			Console.WriteLine ("After 20 delete");
			
//			Console.WriteLine ("  23" + bst.FindNode(23).L.key);
			bst.print (bst.getRoot ());
			Console.WriteLine("Root R  key: " + bst.FindNode(10).R.key);
	//		Console.WriteLine("Root R L  key: " + bst.FindNode(10).R.L.key);
			Console.WriteLine("R 22 key: " + bst.FindNode(22).R.key);
			Console.WriteLine("L 22 key: " + bst.FindNode(22).L.key);
			//Console.WriteLine("L 22: " + bst.FindNode(22).L.key);
			//Console.WriteLine("L R 22: " + bst.FindNode(22).L.R.key);
			
			Console.WriteLine("R R 22 key: " + bst.FindNode(22).R.R.key);
			Console.WriteLine("R L 22 key: " + bst.FindNode(22).R.L.key);
			Console.WriteLine("R L L 22 key: " + bst.FindNode(22).R.L.L.key);
			//Console.WriteLine (bst.FindNode (30).R.key);
			 
			*/
			
			// plus more sons
			// ERROR!
			/*
			bst.DeleteNode (21);
			
			bst.DeleteNode (24);
			bst.DeleteNode (23);
			bst.DeleteNode (22);
			Console.WriteLine("DELETING 20!!!!!");
			bst.DeleteNode(20);
			
			Console.WriteLine ("After 20 delete");
		
//			Console.WriteLine ("  23" + bst.FindNode(23).L.key);
			bst.print (bst.getRoot ());
			Console.WriteLine("Root R  key: " + bst.FindNode(bst.getRoot().key).R.key);
	//		Console.WriteLine("Root R L  key: " + bst.FindNode(10).R.L.key);
			Console.WriteLine("Root R L key: " + bst.FindNode(bst.getRoot().key).R.L.key);
			Console.WriteLine(" R R Root key: " + bst.FindNode(bst.getRoot().key).R.R.key );
			// must blow
			//Console.WriteLine(" R R L Root key: " + bst.FindNode(bst.getRoot().key).R.R.L.key );
			//Console.WriteLine("L 22: " + bst.FindNode(22).L.key);
			//Console.WriteLine("L R 22: " + bst.FindNode(22).L.R.key);
			
			Console.WriteLine("R R R 22 key: " + bst.FindNode(bst.getRoot().key).R.R.R.key );
			//Console.WriteLine (bst.FindNode (30).R.key);
			*/	 
			
			
			
			
			
			
			/*
			bst.DeleteNode (25);
			
			
			
			Console.WriteLine ("After 25 delete");
			
//			Console.WriteLine (" left 20" + bst.FindNode(30).L.key);
			bst.print (bst.getRoot ());
			//Console.WriteLine("R key: " + bst.FindNode(30).R.key);
			
			Console.WriteLine("R 20 key: " + bst.FindNode(20).R.key);
			Console.WriteLine("R L 20 key: " + bst.FindNode(20).R.L.key);
			Console.WriteLine("R R 20 key: " + bst.FindNode(20).R.R.key);
			//Console.WriteLine("R L 5 key: " + bst.FindNode(20).R.R.R.key);		
			
			//Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.R.L.L.key);		
			//Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.R.L.R.key);		
			//Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.R.L.R.R.key);		
			*/
			
			
			
			// proof to delete 30
			/*
			bst.DeleteNode (30);
			Console.WriteLine ("After 30 delete");
			
//			Console.WriteLine (" left 20" + bst.FindNode(30).L.key);
			bst.print (bst.getRoot ());
			//Console.WriteLine("R key: " + bst.FindNode(30).R.key);
			
			Console.WriteLine("R 25 key: " + bst.FindNode(25).R.key);
			Console.WriteLine("R R 25 key: " + bst.FindNode(25).R.R.key);
			Console.WriteLine("R R L 25 key: " + bst.FindNode(25).R.R.L.key);		
			
			//Console.WriteLine("R L 5 key: " + bst.FindNode(25).R.R.L.L.key);		
			Console.WriteLine("R R L R 25 key: " + bst.FindNode(25).R.R.L.R.key);		
			Console.WriteLine("R R L R R 25 key: " + bst.FindNode(25).R.R.L.R.R.key);		
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
			
			
			// Borrando el 40 con un
			//hecho
			/*
			bst.DeleteNode (40);
			Console.WriteLine ("After 40 delete");
			bst.print (bst.getRoot ());
			
			
			// must blow up
			
			//Console.WriteLine ("30 R R  " + bst.FindNode(40).key);
			//Console.WriteLine (" 30 L:  " + bst.FindNode(30).L.key);
			
			Console.WriteLine (" 30 R:  " + bst.FindNode(30).R.key);
			Console.WriteLine (" 30 R L:  " + bst.FindNode(30).R.L.key);
			
			*/
			
			
			// Borrando el 60 con un 60 en su derecha
			//hecho
			/*
			bst.DeleteNode (50);
			Console.WriteLine ("After 50 delete");
			bst.print (bst.getRoot ());
			
			
			// must blow up
			Console.WriteLine ("30 R R:  " + bst.FindNode(30).R.R.key);											
			Console.WriteLine (" 30 R:  " + bst.FindNode(30).R.key);
			Console.WriteLine (" 30 R L:  " + bst.FindNode(30).R.L.key);
			*/
			
			// Borrando el 50 con un 60 en su derecha
			//hecho
			/*
			bst.DeleteNode (50);
			Console.WriteLine ("After 50 delete");
			bst.print (bst.getRoot ());
			
			
			// must blow up
			Console.WriteLine ("30 R R:  " + bst.FindNode(30).R.R.key);											
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
		/*
		int avl rank(int i, nodeptr &n)
		{
		if(n->rank>i)
		{	rank(i, n->left);	}
		else if(n->rank<i)
		{	rank(i, n->right);	}
		else if(n->rank==i)
		{	return n->element;	}
		else
			return -1;

		}
		*/
		
	
		/*
		// se toma el padre F que es el padre de la rotacion, 
		//y el rot, que sera el nodo a rotar		
		public void rotateLeft(TreeNode F, TreeNode P)
		{
			// Antes de la asignacion para rotar
			// verifica si esos valores estan vacios
			// sino, aborta la aplicacion
			
    		TreeNode A = P.L;
    		TreeNode Q = P.R;
    		TreeNode B = P.R.L;
    		TreeNode C = P.R.R;		
			
			// si el numero a rotar recibido es nulo, devuelve una excepcion
    		if(P == null)        
	    		throw new InvalidCastException();
			
			// si el numero a rotar Q
			// que susitutira a P es nulo, devuelve una excepcion			
    		if(P.R ==null)
        		throw new InvalidCastException();
		
			// se conecta el padre de Q, con el padre de P
	    	//Si el valor a rotar es el nodo
			// Se asigna A la cabeza de X el P			
			if(P.key==root.key)
    		{
				Q->P = NULL;
				root=Q;
    		}
    		else
    		{
       		if( key->key < P->P->key)
				P->P->L = key;
       		else
            	P->P->R = key;

       	 	Q->P = P->P;
    		}
				
			TreeNode Ptemp = P;
			P=Q;
			
	// Se asigna la cabeza hacia Q
			P->P = Q;
			key->R = C;
			key->L = P ;
	// Reemplazo para reposicionar los hijos de A
	// Se asignan los hijos debajo de P
			key->L->L = A;
			key->L->R = B;
			Q->L = P;


	// insertar los temporales debajo de A
	// Se actualizan todos los tamanios de los nodos que fueron insertados
			if(A!=NULL)
				UpdateSize(A);
			if(B!=NULL)
				UpdateSize(B);
			if(P!=NULL)
				UpdateSize(P);
			if(C!=NULL)
				UpdateSize(C);
			if(Q!=NULL)
				UpdateSize(Q);

		}	


		void BinarySearchTree::rotate_right(TreeNode )
		{
		// Antes de la rotacion
		// Realizo esto para guiarme al momento de asignar

		if(key==NULL)
			assert(0);
		TreeNode * Q = key;
		if(Q->L==NULL)
		assert(0);
	TreeNode * P = Q->L;
	TreeNode * C = Q->R;
	TreeNode * A = P->L;
	TreeNode * B = P->R;

	// La llave pasa a ser P
	key=P;
	// El padre de P, pasa a ser el Padre de Q
	P->P = Q->P;
	// El padre de Q, pasa a ser P y rota asi a la derecha
	Q->P = P;
	key->R =  Q;
	key->L = A;
	// Se asignan los hijos debajo de P
	key->R->R = C;
	key->R->L = B;

	// Se actualizan los tamanios de los nodos movidos
	if(B!=NULL)
		UpdateSize(B);
	if(C!=NULL)
		UpdateSize(C);
	if(Q!=NULL)
		UpdateSize(Q);
	if(A!=NULL)
		UpdateSize(A);
	if(P!=NULL)
		UpdateSize(P);

		}


	*/	
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
								return (cnt+cur.L.size);
								// si el nodo solo posee valor a su derecha
							} else if (cur.R!=null) {
							
								return (cnt);
							}// si el nodo posee valores en su izq.
							else if (cur.L!=null) {
							return (cnt+cur.L.size);
							}// si no posee ningun valor
							else if (cur.R==null && cur.L==null) {
							return cnt;
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
			Console.WriteLine (cur.key + " Size: "+cur.size);									
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
					Console.WriteLine("PREV!!!!!>>>: " +prev.key);
					Console.WriteLine("CurXXX : " +cur.key);
					//Console.WriteLine("cur.R :" +cur.R.key);										
					Console.WriteLine("cur.R :" +OT);	
					
					if (OT) // Si el numero a borrar se encuentra en el subtree a la derecha del root
					{
						if (cur.R != null) { 
							
							temp = cur.R;
							
							Console.WriteLine("temp.R :" +temp.key);
							Console.WriteLine("prev.R :" +prev.key);
							
							if (temp.L != null) {
								prev = cur;
							
								Console.WriteLine ("!!BEFOREadfasd!!"+prev.key);
								Console.WriteLine ("BEFORE !!!!"+temp.key);
								//bug cuando min y max no tienen profundidad en sus respectivos lugares a
								temp = min (temp,ref prev); 
								Console.WriteLine ("PREV<>PREV.X AFTER!!!!"+prev.key);								
								Console.WriteLine ("AFTER TEMP!!!!"+temp.key);								
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
							
							Console.WriteLine("temp.R !!!!!!:" +temp.key);
								Console.WriteLine("PREV !!!!!!<>:" +prev.key);
							// it must make the temp cur.L?																
							// parent connected to his new right son																						
							Console.WriteLine ("temp" + cur.R.key);															
								Console.WriteLine ("CuR" + cur.key);															
								Console.WriteLine ("CUR.R" + cur.R.key);
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
							
								Console.WriteLine ("!!!! NOT HERER!!!!!!!!!!!!!!!!1");
								Console.WriteLine (cur.key);
								temp = max (temp, ref prev); 
								
								Console.WriteLine ("HERE@FDJFJ " + prev.key);
								Console.WriteLine (temp.key);				
								
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
						
							Console.WriteLine ("{REV" + prev.key);
							Console.WriteLine("temp !!!!!!:" +temp.key);
							// it must make the temp cur.L?																
							// parent connected to his new right son																						
							Console.WriteLine ("!CUUR!" + cur.key);															
								Console.WriteLine ("!CUR L!" + cur.L.key);
								
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
				Console.WriteLine ("moveing" +prev.key);
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
			Console.WriteLine("PREVDFSLKFJ<>!" + prev.key);
			Console.WriteLine("PREVDFSLKFJ<>!x" + x.key);
	
			
			
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
			Console.WriteLine("PREVDFSLKFJ<>!" + prev.key);
			Console.WriteLine("PREVDFSLKFJ<>!x" + x.key);
			
			if(cur.R==null) {
			
				prev = x;
				Console.WriteLine("PREVDFSLKFJ<>!x" + x.key);
			
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
			Console.WriteLine ("COUNT"+p.Count);
			
			
			for(int i=0 ; i<=p.Count;i++)		
			{
						tm = p.Pop();
						updateSize(ref tm);
						Console.WriteLine ("key"+tm.key);	
						
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



