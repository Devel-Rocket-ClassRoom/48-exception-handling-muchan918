using System;

class SafeCalculator
{
    public void Divide(string num1, string num2)
    {
        try
        {
            int a = int.Parse(num1);
            int b = int.Parse(num2);

            int result = a / b;
            Console.WriteLine($"{a} / {b} = {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("올바른 숫자를 입력하세요");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("0으로 나눌 수 없습니다");
        }
        finally
        {
            Console.WriteLine("계산기를 종료합니다");
        }
    }
}