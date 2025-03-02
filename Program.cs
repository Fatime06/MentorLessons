using System;
//TASK1

//class Numbers
//{
//	static void Main()
//	{
//		int[] numbers = { 12, 45, 67, 23, 9, 56, 89, 9, 37, 7, 18, 12, 9, 77 };
//		//1.1
//		//int max = numbers[0];
//		//foreach (int num in numbers)
//		//{
//		//	if (num >= max)
//		//	{
//		//		max = num;
//		//	}

//		//}
//		//Console.WriteLine("En boyuk element= " + max);



//		//1.2
//		//int min = numbers[0];
//		//foreach (int num in numbers)
//		//{ 
//		//	if (num <= min)
//		//	{
//		//		min = num;
//		//	}
//		//}
//		//Console.WriteLine(min);



//		//1.3
//		//int sum = 0;
//		//for (int i = 0; i <= numbers.Length-1; i++)
//		//{
//		//	sum += numbers[i];
//		//}
//		//Console.WriteLine(sum);



//		//1.4
//		//byte n = 0;
//		//for (int i = 0; i < numbers.Length; i++)
//		//{
//		//	if (numbers[i] == 9)
//		//	{ 
//		//		n++;
//		//	}
//		//}
//		//Console.WriteLine(n);


//		//1.5
//		//foreach (byte num in numbers)
//		//{
//		//	if (num >= 10 && num <=30) 
//		//	{
//		//		Console.WriteLine(num);
//		//	}
//		//}



//	}

//}



//TASK2
//class Calculator
//{
//	static void Main()
//	{
//		Console.WriteLine("Herhansi bir reqem daxil edin: ");
//		int num = Convert.ToInt32(Console.ReadLine());

//		for (int i = 1; i <= 9; i++)
//		{
//			Console.WriteLine($"{num} * {i} = {num * i}");
//		}
//	}
//}


//TASK3

//static void Main()
//{
//	Console.WriteLine("Birinci ededi daxil edin: ");
//	int num1 = Convert.ToInt32(Console.ReadLine()); 

//	Console.WriteLine("Ikinci ededi daxil edin: ");
//	int num2 = Convert.ToInt32(Console.ReadLine());

//	Console.WriteLine("Emeliyyati secin: ");
//	string operation = Console.ReadLine();

//	int result;

//	switch (operation)
//	{
//		case "+":

//			result = num1 + num2;
//			Console.WriteLine("Result = " + result);
//			break;

//			case "-":
//			result = num1 - num2;
//			Console.WriteLine("Result = " + result);
//			break;

//			case "*":
//			result = num1 * num2;
//			Console.WriteLine("Result = " + result);
//			break;

//			case "/":
//			if (num2 != 0)
//			{
//				result = num1 / num2;
//				Console.WriteLine("Result = " + result);
//			}
//			else 
//			{
//				Console.WriteLine("Sifira bolme movcud deyil!"); 
//			}
			
//			break;
//			default:
//			Console.WriteLine("Yanlis emeliyyat secildi!");
//			break;


//	}


//}



//TASK4
class Library
{
	static void Main()
	{
		string[] bookTitles = { "Book 1", "Book 2", "Book 3", "Book 4", "Book 5" };
		string[] bookAuthors = { "Author 1", "Author 2", "Author 3", "Author 4", "Author 5" };
		string[] bookGenres = { "Fiction", "Mystery", "Romance", "Fantasy", "Sci-Fi" };
		int[] bookCopiesAvailable = { 5, 3, 7, 0, 2 };

		//Console.WriteLine("Kitablarin detallari: ");

		//for (int i = 0; i < bookTitles.Length; i++)
		//{
		//	Console.WriteLine($"Kitab {i + 1}:");
		//	Console.WriteLine($"Basliq: {bookTitles[i]}");
		//	Console.WriteLine($"Muellif: {bookAuthors[i]}");
		//	Console.WriteLine($"Janr: {bookGenres[i]}");
		//	Console.WriteLine($"Kitab sayi: {bookCopiesAvailable[i]}");
		//	Console.WriteLine("---------------------------------------------");

		//}



		Console.WriteLine("Axtardiginiz kitab adini daxil edin: ");
		string searchBook = Console.ReadLine();

		bool found = false;
		for (int i = 0; i < bookTitles.Length; i++)
		{
			if (bookTitles[i].ToUpper() == searchBook.ToUpper())
			{
				Console.WriteLine("Axtardiginiz kitab tapildi!");
				Console.WriteLine($"Kitab {i + 1}:");
				Console.WriteLine($"Basliq: {bookTitles[i]}");
				Console.WriteLine($"Muellif: {bookAuthors[i]}");
				Console.WriteLine($"Janr: {bookGenres[i]}");
				Console.WriteLine($"Kitab sayi: {bookCopiesAvailable[i]}");
				found = true;
				break;

			}
		}
		if (!found)
		{
			Console.WriteLine("Axtardiginiz kitab tapilmadi!");
		}
	}
}