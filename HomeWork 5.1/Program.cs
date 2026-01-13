// Average Salary Calculation
Console.Write("Enter the number of employees: ");
int count = int.Parse(Console.ReadLine());

double sum = 0;

for (int i = 1; i <= count; i++)
{
   Console.Write($"Enter the employee's salary #{i}: ");
   double salary = double.Parse(Console.ReadLine());
   sum += salary;
}

double average = sum / count;

Console.WriteLine($"The average salary is: {average}");
//------------------------------------------------------------------------

//  Building a graph with stars
Console.Write("Count of rows: ");
int rowCount = int.Parse(Console.ReadLine());
int[] rows = new int[rowCount];

for (int i = 0; i < rowCount; i++)
{
   Console.WriteLine($"Enter row {i + 1} length: ");
   int length = int.Parse(Console.ReadLine());
   rows[i] = length;
}

Console.WriteLine("===============================");

for (int i = 0; i < rowCount; i++)
{
   for (int j = 0; j < rows[i]; j++)
   {
       Console.Write('*');
   }

   Console.WriteLine();
}
//------------------------------------------------------------------------

// 3+7 Primal Numbers
int max;
bool parsed;
do
{
   Console.Clear();
   Console.Write("Enter max number: ");
   parsed = int.TryParse(Console.ReadLine(), out max);
   if (!parsed)
   {
       Console.WriteLine("You entered incorrect number please try again. Press any key to continue or <ESC> to exit.");
       var key = Console.ReadKey();
       if (key.Key == ConsoleKey.Escape)
       {
           return;
       }
   }
}
while (!parsed || max < 0 || max > 10000);

for (; max > 0; max--)
{
   bool isPrimalNum = true;
   for (int currentNumber = max - 1; currentNumber > 1; currentNumber--)
   {
       if (max % currentNumber == 0)
       {
           isPrimalNum = false;
           break;
       }
   }

   if (isPrimalNum)
   {
       Console.WriteLine($"{max} is primal");
   }
}
//------------------------------------------------------------------------

Fibonacci numbers
Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

long a = 0, b = 1;
for (int i = 0; i < n; i++)
{
   Console.Write(a + " ");
   long sum = a + b;
   a = b;
   b = sum;
}
Console.WriteLine(" - First " + n + " Fibonacci numbers");
//------------------------------------------------------------------------

//Payment Calculation
Console.Write("Enter the number of hours worked: ");
double h = double.Parse(Console.ReadLine());
Console.Write("Enter hourly rate: ");
double r = double.Parse(Console.ReadLine());
double payment = h * r;
Console.WriteLine("Payment per day is: " + payment + " uah");
//------------------------------------------------------------------------

// Multiplication Table
Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"multiplication table for the number {number}:");
for (int i = 1; i <= 10; i++)
{
   Console.WriteLine($"{number} × {i} = {number * i}");
}
//------------------------------------------------------------------------
