using System;
using System.Collections.Generic;

try
{
    int[] arr = new int[2];
    arr[100] = 1234;
}
catch
{
    Console.WriteLine("에러가 발생했습니다.");
}

try
{
    int[] arr = new int[2];
    arr[100] = 1234;
}
catch (Exception ex)
{
    Console.WriteLine($"예외 발생: {ex.Message}");
}

string inputNumber = "3.14";
int number = 0;

try
{
    number = Convert.ToInt32(inputNumber);
    Console.WriteLine($"입력한 값: {number}");
}
catch (FormatException fe)
{
    Console.WriteLine($"에러 발생: {fe.Message}");
    Console.WriteLine($"{inputNumber}는 정수여야 합니다.");
}

try
{
    Console.Write("숫자를 입력하세요: ");
    string input = Console.ReadLine();
    int number1 = int.Parse(input);

    int[] arr = new int[5];
    arr[number1] = 100;

    Console.WriteLine($"arr[{number1}]에 100을 저장했습니다.");
}
catch (FormatException)
{
    Console.WriteLine("숫자 형식이 아닙니다!");
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("인덱스가 0~4 범위를 벗어났습니다!");
}
catch (Exception ex)
{
    Console.WriteLine($"알 수 없는 오류: {ex.Message}");
}