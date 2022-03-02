int num1;
int num2;
int result = 0;
char symbol;

// restart bliver brugt af goto når man trykker på r
restart:

Console.Write("Tal 1: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Tal 2: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Symbol +, -, /, *: ");
symbol = Convert.ToChar(Console.ReadLine());

// method der ganger num1 og num2 sammen og returner result
int Multiply(int num1, int num2) => result = num1 * num2;

// method der dividere num1 og num2 og returner result
int Divide(int num1, int num2) => result = num1 / num2;

//method der pluser num1 og num2 og returner result
int Plus(int num1, int num2) => result = num1 + num2;

//method der minuser num1 og num2 og returner result
int Minus(int num1, int num2) => result = num1 - num2;

//en switch der tager symbol laver den til en string
switch (symbol.ToString())
{
    case "+":
        Plus(num1, num2);
        break;
    case "-":
        Minus(num1, num2);
        break;
    case "*":
        Multiply(num1, num2);
        break;
    case "/":
        Divide(num1, num2);
        break;
}

Console.WriteLine("result: " + result);
string test = "";
Console.WriteLine("To restart press R");
//hivs man trykker på r keyen bliver consolen cleared og vi gå til restart
if (Console.ReadKey().Key == ConsoleKey.R)
{
    Console.Clear();
    goto restart;
}
Console.WriteLine();