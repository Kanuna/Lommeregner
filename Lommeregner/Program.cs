int num1;
int num2;
int result = 0;
char symbol;

Console.WriteLine("Tal 1: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Tal 2: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Symbol + - / *: ");
symbol = Convert.ToChar(Console.ReadLine());

Console.WriteLine("result: " + result);


int Multiply(int num1, int num2)
{
    return result = num1 * num2;
}

int Divide(int num1, int num2)
{
    return result = num1 / num2;
}

int Plus(int num1, int num2) => result = num1 + num2;

int Minus(int num1, int num2) => result = num1 - num2;
