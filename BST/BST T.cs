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
	// FINE WITH SIZES
	/*
	bst.AddNode (10, 1);
	bst.AddNode (13, 1);
	bst.AddNode (5, 3);
	bst.AddNode (3, 4);
	bst.AddNode (4, 5);
	bst.AddNode (1, 6);
	bst.AddNode (2, 7);
	*/
	/*
	bst.Find(50);
	bst.AddNode (18, 1);
	
	bst.AddNode (12, 1);
	bst.AddNode (22, 3);
	
	bst.AddNode (10, 4);
	bst.AddNode (13, 5);
	bst.AddNode (16, 5);
	bst.AddNode (15, 6);
	bst.AddNode (14, 6);
	bst.AddNode (17, 6);
	
	bst.AddNode (29, 6);
	bst.AddNode (5, 7);
	
	bst.AddNode (11, 5);
	
	bst.AddNode (35, 7);
	
	bst.AddNode (4, 5);
	bst.AddNode (7, 6);
	bst.AddNode (2, 7);
	
	bst.AddNode (6, 6);
	bst.AddNode (9, 7);
	bst.AddNode (8, 7);
	
	bst.AddNode (24, 1);
	bst.AddNode (27, 1);
	bst.AddNode (23, 3);
	bst.AddNode (25, 1);
	bst.AddNode (28, 1);
	
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
	
	Console.WriteLine("39 RNK = " + bst.rank(39 ));
	
	bst.printSizes(bst.getRoot());
	bst.print(bst.getRoot());
	
	*/


	bst.AddNode (10, 1);
	bst.AddNode (20, 3);
	bst.AddNode (15, 4);
	bst.AddNode (25, 5);
	bst.AddNode (30, 6);
	//bst.AddNode (15, 7);
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

    Console.WriteLine("13 RNK = " + bst.rank(13 ));
    Console.WriteLine("14 RNK = " + bst.rank(14 ));
	Console.WriteLine("15 RNK = " + bst.rank(15 ));
	
	
	Console.WriteLine("16 RNK = " + bst.rank(16 ));
	Console.WriteLine("17 RNK = " + bst.rank(17 ));
	
	Console.WriteLine("18 RNK = " + bst.rank(18 ));
	Console.WriteLine("15 RNK = " + bst.rank(15 ));
	
	
	
	Console.WriteLine("2 RNK = " + bst.rank(2 ));
	Console.WriteLine(bst.rank(2)+" SELECT = " + bst.Select( bst.rank(2 )));
	Console.WriteLine("4 RNK = " + bst.rank(4 ));
	Console.WriteLine(bst.rank(4)+" SELECT = " + bst.Select( bst.rank(4 )));
	Console.WriteLine("7 RNK = " + bst.rank(7 ));
	Console.WriteLine(bst.rank(7)+" SELECT = " + bst.Select( bst.rank(7 )));
	Console.WriteLine("9 RNK = " + bst.rank(9 ));
	
	Console.WriteLine("22 RNK = " + bst.rank(22 ));
	Console.WriteLine("29 RNK = " + bst.rank(29 ));
	Console.WriteLine("35 RNK = " + bst.rank(35 ));
	
	
	Console.WriteLine("24 RNK = " + bst.rank(24 ));
	Console.WriteLine("23 RNK = " + bst.rank(23 ));
    Console.WriteLine(bst.rank(23)+" SELECT = " + bst.Select( bst.rank(23 )));
	Console.WriteLine("25 RNK = " + bst.rank(25 ));	
            Console.WriteLine(bst.rank(25)+" SELECT = " + bst.Select( bst.rank(25 )));
	Console.WriteLine("27 RNK = " + bst.rank(27 ));
	//Console.WriteLine(bst.rank(27)+" RNK = " + bst.Select( bst.rank(27 )));
            Console.WriteLine("28 RNK = " + bst.rank(28 ));
	//Console.WriteLine(bst.rank(28)+" RNK = " + bst.Select( bst.rank(28 )));
	Console.WriteLine("39 RNK = " + bst.rank(39 ));
            //Console.WriteLine(bst.rank(39)+" RNK = " + bst.Select( bst.rank(39 )));
            
	Console.WriteLine("10 RNK = " + bst.rank(10 ));
            Console.WriteLine("8 SELECT = " + bst.Select(8 ));
	bst.printSizes(bst.getRoot());

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
	// 16,18,19,17
	// bug with size
	/*
	bst.DeleteNode(16);
	bst.DeleteNode(18);
	bst.DeleteNode(19);
	
	
	Console.WriteLine ("After 16,18,19 delete");
	bst.print (bst.getRoot ());
	
	Console.WriteLine (" Root:  " + bst.getRoot().key);
	Console.WriteLine ("Root R (20):  " + bst.getRoot().R.key);
	Console.WriteLine ("Root R L (15):  " + bst.getRoot().R.L.key);
	Console.WriteLine ("Root R L L (14):  " + bst.getRoot().R.L.L.key);
	Console.WriteLine ("Root R L R:(17)  " + bst.getRoot().R.L.R.key);
	Console.WriteLine ("Root R R :  " + bst.getRoot().R.R.key);
	
	bst.DeleteNode(17);
	 
	Console.WriteLine ("After 17 delete");
	Console.WriteLine (" Root:  " + bst.getRoot().key);
	Console.WriteLine ("Root R (20):  " + bst.getRoot().R.key);
	Console.WriteLine ("Root R L (15):  " + bst.getRoot().R.L.key);
	Console.WriteLine ("Root R L L (14):  " + bst.getRoot().R.L.L.key);
	
	bst.printSizes();
	
	//	Console.WriteLine ("Root R L R:(17)  " + bst.getRoot().R.L.R.key);
	*/


	// bug with size
            /*
	bst.DeleteNode(23);
	//bst.DeleteNode(21);


	Console.WriteLine ("After 23 delete");
	bst.print ();

	Console.WriteLine (" Root:  " + bst.getRoot().key);
	Console.WriteLine ("Root R (20):  " + bst.getRoot().R.key);
	Console.WriteLine ("Root R R L (22):  " + bst.getRoot().R.R.L.key);
	Console.WriteLine ("Root R R L R (24):  " + bst.getRoot().R.R.L.R.key);
	Console.WriteLine ("Root R R L L:(21)  " + bst.getRoot().R.L.R.key);
	//Console.WriteLine ("Root R R :  " + bst.getRoot().R.R.key);

	bst.printSizes();
	//	Console.WriteLine ("Root R L R:(17)  " + bst.getRoot().R.L.R.key);

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
	
//	Console.WriteLine (" left 20" + bst.FindNode(30).L.key);
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
	
//	Console.WriteLine ("  23" + bst.FindNode(23).L.key);
	bst.print (bst.getRoot ());
	Console.WriteLine("Root R  key: " + bst.FindNode(10).R.key);
	//	Console.WriteLine("Root R L  key: " + bst.FindNode(10).R.L.key);
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
	// ERROR!/*
	/*
	bst.DeleteNode (21);
	
	bst.DeleteNode (24);
	bst.DeleteNode (23);
	bst.DeleteNode (22);
	Console.WriteLine("DELETING 20!!!!!");
	bst.DeleteNode(20);
	
	Console.WriteLine ("After 20 delete");
	
//	Console.WriteLine ("  23" + bst.FindNode(23).L.key);
	bst.print (bst.getRoot ());
	Console.WriteLine("Root R  key: " + bst.FindNode(bst.getRoot().key).R.key);
	//	Console.WriteLine("Root R L  key: " + bst.FindNode(10).R.L.key);
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
	
//	Console.WriteLine (" left 20" + bst.FindNode(30).L.key);
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
	
//	Console.WriteLine (" left 20" + bst.FindNode(30).L.key);
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
	
//	Console.WriteLine (" left 20" + bst.FindNode(30).L.key);
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

	// Borrando el 1 con un
	// siendo leave! buug
	/*
	bst.DeleteNode (3);
	bst.DeleteNode (2);
	bst.DeleteNode (1);
	
	Console.WriteLine ("After 1 delete");
	
	
	bst.print (bst.getRoot ());
	
	Console.WriteLine (" FInD:  " + bst.getRoot().key);
	
	Console.WriteLine ("Root L:  " + bst.getRoot().L.key);
	Console.WriteLine ("Root L:  " + bst.getRoot().L.L.key);
	Console.WriteLine ("Root L:  " + bst.getRoot().L.L.L.key);
	
	Console.WriteLine (" FInD:  " + bst.FindNode(3).key);
	//Console.WriteLine (" L " + bst.FindNode(3).L.key);
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
	bst.DeleteNode (60);
	Console.WriteLine ("After 60 delete");
	bst.print (bst.getRoot ());
	
	Console.WriteLine (" 40 R:  " + bst.FindNode(40).R.key); // debe ser 50
	// must blow up
	//Console.WriteLine ("30 R R:  " + bst.FindNode(40).R.R.key);	
	//Console.WriteLine (" 30 R L:  " + bst.FindNode(40).R.L.key);
	
	
	// Borrando el 50 con un 60 en su derecha
	//hecho
	*/
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
	    	throw new EmptyTreeException("You cannot rotate an empty Tree!");
		if(P.R==null)
			//throw new InvalidRotationException("You cannot rotate an empty node!");
			return ;
	// si el numero a rotar Q
	// que 	
    	
	// Estas asignaciones se hacen para tener una mejor abstraccion
		Console.WriteLine( "ROTING P: " + P.key +" Q "+ P.R.key);
    	TreeNode A = P.L;
    	TreeNode Q = P.R;
    	TreeNode B = Q.L;
    	TreeNode C = Q.R;	
	// si el numero a rotar es la raiz, se asigna la raiz a Q
		
		/*
		 * 
		*/
		
		
		TreeNode tmp = P;
		P.R=B;
		Q.L = P;
			
		//P=Q;
		/*
		P = Q;
		P.key = Q.key;
		P.val = Q.val;
		
		P.L = P;
		P.R = C ;	
	  	Q = tmp;
		Q.R = B;
		Q.L = A;
		*/
			
		if(P.key==root.key)
    	{
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
		
		
	// se conecta el padre de Q, con el padre de P
		
			
	 //Si el valor a rotar es el nodo
	// Se asigna A la cabeza de X el P	
	// Temporal de P
	/*
		TreeNode Ptemp = P;
		P=Q;
	
	// Se asigna la cabeza hacia Q
	
		Ptemp.R = C;
		Ptemp.L = P ;
	// Reemplazo para reposicionar los hijos de A
	// Se asignan los hijos debajo de P
		if(Ptemp.L.L !=null)
			Ptemp.L.L = A;
		else
			Ptemp.L.L = null;
		if(Ptemp.L.R!=null)
			Ptemp.L.R = B;
		else
			Ptemp.L.R = null;
		if(Q.L!=null)
			Q.L = P;
		else
			Q.L=null;

			 */
	// insertar los temporales debajo de A
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
	
		if(Q==null)
			throw new EmptyTreeException("You cannot rotate an empty Tree!");
	
		if(Q.L==null)
			//throw new InvalidRotationException("You cannot rotate an empty node!");
			return ;
		Console.WriteLine( "ROTING Q: " + Q.key +" P "+ Q.L.key);
		TreeNode P = new TreeNode();
		TreeNode C = new TreeNode();
		TreeNode B = new TreeNode();
		TreeNode A = new TreeNode();
			
		P = Q.L;
		C = Q.R;
			
		B=  P.R;
		A = P.L;
		
			
		TreeNode Ptemp = P;
		Q.L = P.R;
		P.R= Q;
		
			
		if(Q.key==root.key)
    	{			
			root=P;
    	}
    	else if (F!=null) // si no es 
    	{
			// reubica la posicion de hijo con relacion a su padre
       		if(F.R == Q)
				F.R = P;
			else if (F.L == Q)
				F.L = P;
    	} else if (F==null)
			root =P;
		
			
			/*
			if (Q.L.R==null)
				B = null;
			else 
			*/
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
	//Console.WriteLine("THE MOVING THING! "+cur.key);

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
	}


	}

	// si se ha encontrado el valor
	// y si se encuentra a su derecha
	return -1;
	}	 // a medida que vaya avanzando la busqueda del rank, el contador aumentara +1
        
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
			
        if (nth_el >  (size-(root.R.size+1)) )
			{
        	OT = true;                    
			rankid = size-(root.R.size+1);
			}
		// si es menor el nth_el que el rank del root, 
		// la orientacion cambia a la izquierda y guarda el rank en rankid		
       	else if (nth_el <  (size-(root.R.size+1)) )
			{
        	OT = false;                    
			rankid =  size-(root.R.size+1);
			}
        // si no posee a su derecha raiz
		else // devuelve el root  si es numero buscado es el rank buscado
    		if ( nth_el >  (root.L.size) )
			{
        	 	rankid = root.L.size;
				OT = true;    
			}
      		else if ( nth_el <  (root.L.size) )
			{
            	rankid = root.L.size;
				OT = false;
			}
		
	
	// Si el key es mayor que el root, la orientacion se queda en true, ya que ira a la derecha a buscar por el rank	
	
	
	while(cur !=null)
	{
	// si encuentra el nodo a calcular
	Console.WriteLine("KEY! "+cur.key + " CNT: " +cnt+ " NTH_EL: "+ nth_el);
	
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
					
	} else {
		if (cur.R!=null && cur.L!=null)
		{
			if(cnt == 0) 
			{
	    		if(nth_el==cur.L.size)
            		return (cur.key);
			rankid = cur.L.size;
			}
			else if (cnt > 0)	
			{
	    		if (nth_el == (cur.L.size+cnt) )
            		return (cur.key);
			rankid = (cur.L.size+cnt);
			} 
	} else if (cur.R!=null)
	{
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
		if(cnt==0)
		{
			if( nth_el ==cur.size-1)
        		return cur.key;
			rankid = cur.size-1;
		}
		if(cnt>0)
		{
			if (nth_el==cnt)
        		return cur.key;
			rankid = cnt;
		}

	}

	}
				
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
// si se ha encontrado el valor
	// y si se encuentra a su derecha
	return -1;
		 // a medida que vaya avanzando la busqueda del rank, el contador aumentara +1
        

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
	Console.WriteLine (cur.key + " Size: "+cur.size);	
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
	Console.WriteLine (cur.key);	
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
			Console.WriteLine("PREV!!!!!>>>: " +prev.key);
			Console.WriteLine("CurXXX : " +cur.key);
			//Console.WriteLine("cur.R :" +cur.R.key);	
			Console.WriteLine("cur.R :" +cur.key);	

			if (OT) // Si el numero a borrar se encuentra en el subtree a la derecha del root
			{	// Si el numero a borrar posee valores a su derecha
				if (cur.R != null) { 
				// mueve el temporal a su derecha
					temp = cur.R;

					Console.WriteLine("temp.R :" +temp.key);
					Console.WriteLine("prev.R :" +prev.key);

				// si el nodo a borrar hacia la derecha, posee hijos a su izwquierda

					if (temp.L != null) {
								
						prev = cur;
						Console.WriteLine ("!!BEFOREadfasd!!"+prev.key);
						Console.WriteLine ("BEFORE !!!!"+temp.key);
	//
						temp = min (temp,ref prev); 
						Console.WriteLine ("PREV<>PREV.X AFTER!!!!"+prev.key);	
						Console.WriteLine ("AFTER TEMP!!!!"+temp.key);	
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
							Console.WriteLine("GOOOOOOOTO");
						}
					}
					else if (cur.R != null) {
								
						Console.WriteLine("temp.R !!!!!!:" +temp.key);
						Console.WriteLine("PR<>EV !!!!!!<>:" +prev.key);
						// it must make the temp cur.L?	
						// parent connected to his new right son	
						Console.WriteLine ("temp" + cur.R.key);	
						Console.WriteLine ("CuR" + cur.key);	
						Console.WriteLine ("CUR.R" + cur.R.key);
						prev.R = temp;

						if(cur.L!=null)	{// this can be>
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
					Console.WriteLine ("!!!! NOT HERER!!!!!!!!!!!!!!!!1");
					Console.WriteLine (cur.key);
					temp = max (temp, ref prev); 
					Console.WriteLine ("HERE@FDJFJ " + prev.key);
					Console.WriteLine (temp.key);	
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
						Console.WriteLine("To rotate right " + _key);
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
			Console.WriteLine ("key"+upd.key + "CNT" + p.Count);	
		}

		return ;
		} // si aun no se ha encontrado el nodo a borrar, continua buscando	
		else if (_key > cur.key) 
		{	  	 
			prev = cur;	
			p.Push(cur);
			Console.WriteLine ("moveing" +prev.key);
			cur = cur.R;	
			Console.WriteLine ("nxt" +cur.key);	
		} else if (_key < cur.key) {	
			p.Push(cur);	  	 	  
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



	public void AddNode(int _key, int _val)
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
						Console.WriteLine("To rotate right " + _key);
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



	public void updateSize(ref TreeNode x) 
	{

	if(x==null)
	return;	
	//Actualiza dos hijos
	if(x.R!=null && x.L !=null)
	{
	x.size = x.R.size+x.L.size+1;	
	} else if( x.L!=null) // actualiza hijo izquierdo
	{	
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

	public class EmptyTreeException : System.Exception
	{
    //Constructors. It is recommended that at least all the
    //constructors of
    //base class Exception are implemented
    public EmptyTreeException() : base() { 

	}



    public EmptyTreeException(string message) : base(message) { 
	}
    public EmptyTreeException(string message, Exception e) : base(message, e) { }
    //If there is extra error information that needs to be captured
    //create properties for them.

    private string strExtraInfo;
    public string ExtraErrorInfo
    {
        get
        {
            return strExtraInfo;
        }

        set
        {
            strExtraInfo = value;
        }
    }
	}
	
	public class InvalidRotationException : System.Exception
	{
    //Constructors. It is recommended that at least all the
    //constructors of
    //base class Exception are implemented
    public InvalidRotationException() : base() { 

	}



    public InvalidRotationException(string message) : base(message) { 
	}
    public InvalidRotationException(string message, Exception e) : base(message, e) { }
    //If there is extra error information that needs to be captured
    //create properties for them.

    private string strExtraInfo;
    public string ExtraErrorInfo
    {
        get
        {
            return strExtraInfo;
        }

        set
        {
            strExtraInfo = value;
        }
    }
	}
	
	
}

