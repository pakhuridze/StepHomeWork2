// 1. რიცხვების ბეჭდვა (1–10)
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}

// 2. რიცხვების ჯამი (1–100)
//int numCounter = 0;
//for (int i = 1; i <= 100; i++)
//{
//    numCounter += i;
//}
//Console.WriteLine($"Sum = {numCounter}");

// 3. კენტი რიცხვების ბეჭდვა (1–20)
//for (int i = 1; i <= 20; i += 2)
//{
//    Console.WriteLine(i);
//}

// 4. რიცხვის ტაბულა (Multiplication Table)
//Console.Write("Enter n: ");
//int n = int.Parse(Console.ReadLine());

//for (int j = 1; j <= 9; j++)
//{
//    Console.WriteLine($"{n} x {j} = {n * j}");
//}

// 5. უკუღმა ბეჭდვა (10–1)
//int counter = 10;
//while (counter > 0)
//{
//    Console.WriteLine(counter);
//    counter--;
//}

// 6. რიცხვის ფაქტორიალი (n!)
//Console.Write("Enter n: ");
//int n = int.Parse(Console.ReadLine());

//int factorial = 1;
//for (int i = 1; i <= n; i++)
//{
//    factorial *= i;
//}
//Console.WriteLine($"Factorial = {factorial}");

// 7. სიმბოლოს გამეორება ("*")
//for (int i = 0; i < 10; i++)
//{
//    Console.Write("*");
//}

// 8. While – ჯამი ≥ 50
//int counter = 0;
//int sum = 0;
//while (sum <= 50)
//{
//    sum += counter;
//    counter++;
//}
//Console.WriteLine($"Sum = {sum}");

// 9. Do-While – პაროლი
//string password = "1234";
//string? userInput;
//do
//{
//    Console.Write("Enter password: ");
//    userInput = Console.ReadLine();
//}
//while (userInput != password);
//Console.WriteLine("Entered password correct!");

// 12. რიცხვის პალინდრომი
//int userInput = int.Parse(Console.ReadLine());
//string inputStr = userInput.ToString();
//string reversed = "";
//for (int i = inputStr.Length - 1; i >= 0; i--)
//{
//    reversed += inputStr[i];
//}
//string result = (inputStr == reversed)
//    ? "Palindrome"
//    : "Not Palindrome.";
//Console.WriteLine(result);

//13.რიცხვების ფიბონაჩის მიმდევრობა

//Console.Write("Enter n: ");
//int n = int.Parse(Console.ReadLine());   

//int a = 0, b = 1;
//for (int i = 0; i < n; i++)
//{
//    Console.Write($"{a} ");
//    int c = a + b;
//    a = b;
//    b = c;
//}