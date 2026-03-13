using System;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("=== 경로 검증 테스트 ===");
FilePathValidator filePathValidator = new FilePathValidator();

string[] paths =
{
    "C:/Users/data/report.txt",
    "",
    ">",
    new string('a', 261)
};

foreach (var path in paths)
{
    try
    {
        filePathValidator.ValidatePath(path);
    }
    catch (ArgumentNullException)
    {
        Console.WriteLine("[ArgumentNull 오류] 경로는 null이거나 비어있을 수 없습니다.");
    }
    catch (ArgumentOutOfRangeException)
    {
        Console.WriteLine("[ArgumentOutOfRange 오류] 경로 길이가 260자를 초과합니다.");
    }
    catch (ArgumentException ae)
    {
        Console.WriteLine($"[Argument 오류] {ae.Message}");
    }
}

Console.WriteLine();
Console.WriteLine("=== 확장자 검증 테스트 ===");

string[] allowedExtensions = { ".txt", ".csv" };

string[] testFiles =
{
    "data.txt",
    "table.csv",
    "program.exe"
};

foreach (var file in testFiles)
{
    try
    {
        filePathValidator.ValidateExtension(file, allowedExtensions);
    }
    catch (ArgumentException ae)
    {
        Console.WriteLine($"[Argument 오류] {ae.Message}");
    }
}