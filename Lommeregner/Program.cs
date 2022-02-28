int num1;
int num2;
int result;
char symbol;

Console.Write("Tal 1: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Tal 2: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Symbol +, -, /, *: ");
symbol = Convert.ToChar(Console.ReadLine());

Console.WriteLine("result: " + result);


int Multiply(int num1, int num2) => result = num1 * num2;

int Divide(int num1, int num2) => result = num1 / num2;

int Plus(int num1, int num2) => result = num1 + num2;

int Minus(int num1, int num2) => result = num1 - num2;


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