int firstNumber = 11;
int secondNumber = 22;
SwapByValue(firstNumber, secondNumber);
Console.WriteLine($"firstNumber = {firstNumber}, secondNumber = {secondNumber}");
SwapByReference(ref firstNumber, ref secondNumber);
Console.WriteLine($"firstNumber = {firstNumber}, secondNumber = {secondNumber}");

static void SwapByValue(int num1, int num2)
{
    // Swap the value of num1 with num2
    int temp = num1;
    num1 = num2;
    num2 = temp;
}

static void SwapByReference(ref int num1, ref int num2)
{
    // Swap the value of num1 with num2
    int temp = num1;
    num1 = num2;
    num2 = temp;
}
