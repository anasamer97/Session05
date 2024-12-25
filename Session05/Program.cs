namespace Session05
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Free Area
			#region Understanding passing by reference
			//int x = 10;
			//modify(ref x);
			//Console.WriteLine(x);
			#endregion





			#region Validating input using try.parse() and using SumSub() function
			int NumberOne = GetValidEntry("Enter first number");
			int NumberTwo = GetValidEntry("Enter second number");
			int sum, sub;
			SumSub(NumberOne, NumberTwo, out sum, out sub);
			Console.WriteLine($"Sum = {sum} and Sub = {sub}"); 
			#endregion

			#endregion
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
			*/
			#endregion

			#region Assignment 05
			#region Q1
			// 1- Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example
			/*
			Passing by value:  
			- In passing by value the value is passed to swap function stack frame and then it is manipulated there and then the CLR deletes it

			Passing by reference:
			- In passing by reference the whole variable is passed to the swap stack frame
			*/

			// For example || Pass by value
			//Console.WriteLine("Pass by value");
			//int a = 1;
			//int b = 5;
			//Console.WriteLine("Before swap using pass by value");
			//Console.WriteLine($"a = {a}");
			//Console.WriteLine($"b = {b}");
			//Console.WriteLine("After swap using pass by value");
			//Swap(a, b);
			//Console.WriteLine($"a = {a}");
			//Console.WriteLine($"b = {b}");

			//// Now for pass by reference
			//Console.WriteLine("Pass by reference after using swap");
			//Swap(ref a, ref b);
			//Console.WriteLine($"a = {a}");
			//Console.WriteLine($"b = {b}");
			#endregion

			#region Q2 
			// 2 - Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
			// In passing by reference type by value I pass the value (which holds the address)  
			// Pass the reference type by value || Numbers => Address
			//int[] SomeNumbers = { 1, 2, 3 };
			// SumArray() has the address of the array in the heap
			// Console.WriteLine(SumArray(SomeNumbers));
			// Console.WriteLine(SomeNumbers[0]);

			// Now passing a reference by reference 
			// int[] OtherNumbers = { 1, 2, 3 };
			// SumArray() has the address of the array in the heap
			// Console.WriteLine(SumArray(SomeNumbers));
			// wConsole.WriteLine(SomeNumbers[0]);
			#endregion

			#region Q3
			// 3- Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
			/*
			 public static void SumAndSubtract(int num1, int num2, int num3, int num4, out int sum, out int subtract)
			{
				sum = num1 + num2;
				subtract = num1 - num2;

			}*/
			/*int A = 10;
			int B = 20;
			int sum, subtract;
			SumAndSubtract(A, B, out sum, out subtract);*/
			#endregion

			#region Q4
			// 4 - Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
			//SumDigits(25);
			//Console.WriteLine(SumDigits(12));

			#endregion
			#endregion
			#region Q5
			// 5 - Write a function that checks if a number is a prime or not
			//Console.WriteLine(IsPrime(4));
			#endregion


			#region Q6
			// 6 - Create a function to return the minimum and maximum values stored in the array using reference parameters
			// Just testing something. 
			//int[] numbers = { 1, 2, 2 };
			//Console.WriteLine(SumArrayExample(numbers));

			// Actual solution
			//int[] numbers = { 3, 7, 2, 9, 1, 4 };
			//int min, max;

			//MinMaxArray(numbers, out min, out max);

			//Console.WriteLine($"Minimum: {min}");
			//Console.WriteLine($"Maximum: {max}");


			#region Q7
			// 7 - Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
			Console.WriteLine(CalculateFactorial(6));
			#endregion

			#region Q8
			// 8.Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

			/*string originalString = "hello";
			int position = 1;
			char newChar = 'a';

			string modifiedString = ChangeChar(originalString, position, newChar);

			Console.WriteLine($"Original string: {originalString}");
			Console.WriteLine($"Modified string: {modifiedString}");*/
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
		#region Pass by value
		public static void Swap(int X, int Y)
		{
			int temp = X;
			X = Y;
			Y = temp;
		}
		public static void Swap(ref int X, ref int Y)
		{
			int temp = X;
			X = Y;
			Y = temp;
		}
		public static int SumArray(int[] Arr)
		{
			int sum = 0;
			Arr[0] = 100;
			for (int i = 0; i < Arr.Length; i++)
			{
				sum = sum + Arr[i];
			}
			return sum;
		}

		public static int SumArray(ref int[] Arr)
		{
			int sum = 0;
			Arr[0] = 100;
			for (int i = 0; i < Arr.Length; i++)
			{
				sum = sum + Arr[i];
			}
			return sum;
		}

		public static void SumAndSubtract(int num1, int num2, int num3, int num4, out int sum, out int subtract)
		{
			sum = num1 + num2;
			subtract = num1 - num2;

		}

		public static int SumDigits(int num)
		{
			int sum = 0;
			while (num > 0)
			{
				sum = sum + num % 10;
				num = num / 10;
			}
			return sum;
		}

		public static int SumArrayExample(int[] Arr)
		{
			int sum = 0;
			for (int i = 0; i < Arr.Length; i++)
			{
				sum = sum + Arr[i];
			}
			return sum;
		}


		public static bool IsPrime(int number)
		{
			if (number <= 1) return false;
			for (int i = 2; i <= Math.Sqrt(number); i++)
			{
				if (number % i == 0) return false;
			}
			return true;
		}

		static void MinMaxArray(int[] array, out int min, out int max)
		{
			if (array == null || array.Length == 0)
			{
				throw new ArgumentException("Array must not be null or empty.");
			}

			min = array[0];
			max = array[0];

			foreach (int num in array)
			{
				if (num < min)
				{
					min = num;
				}
				if (num > max)
				{
					max = num;
				}
			}
			#endregion

			

		}

		static long CalculateFactorial(int num)
		{
			long factorial = 1;

			for (int i = 1; i <= num; i++)
			{
				factorial = factorial * i;
			}

			return factorial;
		}

		static string ChangeChar(string input, int position, char newChar)
		{
			
			if (string.IsNullOrEmpty(input))
			{
				throw new ArgumentException("Input string cannot be null or empty.");
			}

			if (position < 0 || position >= input.Length)
			{
				throw new ArgumentOutOfRangeException(nameof(position), "Position must be within the string's bounds.");
			}

			char[] charArray = input.ToCharArray();
			charArray[position] = newChar;

			return new string(charArray);
		}
	}
}
#endregion