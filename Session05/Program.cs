namespace Session05
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Session 05 Demo & Notes
			#region Casting (Boxing and unboxing)
			// Reference type casting => convert from reference type to another reference type
			// Boxing => convert from value type to reference type
			// Value type examples like int is stored in the stack
			// Boxing is the process of storing the value type that is typically stored in the stack to be stored in the heap
			// Unboxing => convert from reference type to value type
			// Unboxing is the process of storing the reference type that is typically stored in the heap to be stored in the stack
			// Object is a class all data types inherit from it
			Object obj = new object();
			// Points to a string || Casting
			obj = "Ahmed"; // Reference type casting

			obj = 2;
			#endregion




			//obctje

			#region Exploring Datatypes and explaining it's properties
			// int is a struct datatype 
			int X = 5; // 4 bytes
					   // Stored in heap -- Stored in 8 bytes because each character is 2 bytes in C# and they are 4 characters in total so 2 * 4 = 8 byte
			string Name = "test";
			// Explaining referece type 
			Point P1;
			// Allocate 4 bytes in the stack
			// Zero bytes allocate in heap
			P1 = new Point();
			// 8 bytes because int x = 2 byte and int y = 2 byte			  
			// 1. Allocate required bytes at heap		  
			// 2. Intialize cross out allocated bytes of object
			// 3. Call user defined constructor if exists
			// 4 Assign reference p1 to allocated object


			Point P2 = new Point();
			// P2 now points to the same object as P1
			// Unlike value type like int which holds the actual value in the stack directly without pointing to another memory location in the heap
			// P2 is now a unreachable object in the heap
			// Garbage collector will remove this object from the heap and it does pause execution of the program
			P2 = P1;
			P1.x = 10;
			Console.WriteLine(P1.x);
			Console.WriteLine(P2.x);


			#region Exploring Object datatype

			#endregion
			#endregion

			#endregion
			#region Using classes from external class file
			Messeges.Hello();
			Messeges.Waiting();
			Messeges.Bye();
			#endregion
		}
		#region Classes Example
		// Class in the sample program.cs file

		/*
		class Messeges
		{
			void Hello()
			{
				Console.WriteLine("Hello");
			}

			void Waiting()
			{
				Console.WriteLine("Waiting");
			}

			void Bye()
			{
				Console.WriteLine("Bye");
			}
		}

		*/

		// To use a class you can do one of two things; you can either create an object of the class or you can make the class static

		#endregion
	}
}
