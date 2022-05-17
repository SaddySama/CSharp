Console.WriteLine("Hello Alliens !");
string str = "SadhuN";
double rate = 10.79;
Console.WriteLine("rate is : " + rate);
//Reading input values
int a, b;
Console.WriteLine("enter the values for a and b : ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("sum of the numbers is : " + (a + b));
//Math functions 
Console.WriteLine("Max of the two numbers is : " + Math.Max(a, b));
Console.WriteLine("Round of : " + Math.Round(rate));
//strings
Console.WriteLine("name is : " + str);
Console.WriteLine("first characters : " + str[0]);
Console.WriteLine("to upper : " + str.ToUpper());
Console.WriteLine("to lower : " + str.ToLower());
string FirstName = "Sadhun";
string SecondName = "Arun";
string name = $"My full name is : {FirstName} {SecondName}";
Console.WriteLine(name);
//boolean
Console.WriteLine(10 < 1);
//if-else
if (10 > 1)
{
    Console.WriteLine("YES");
}
else Console.WriteLine("NO");
//ternary operator
int num = 15;
string ter = (num < 20) ? "Good" : "Bad";
Console.WriteLine(ter);
//switch case
Console.WriteLine("ente the option : ");
int ch = Convert.ToInt32(Console.ReadLine());
switch (ch)
{
    case 1:
        Console.WriteLine("option 1");
        break;
    case 2:
        Console.WriteLine("option 2");
        break;
}
//loops
for (int i = 0; i < 5; ++i) Console.WriteLine("i : " + i);
int k = 10;
while (k-- > 0)
{
    if ((k & 1) == 1) continue;
    Console.WriteLine("K val : " + k);
    if (k == 1) break;
}
//Arrays
int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int i in numbers) Console.WriteLine(i);
