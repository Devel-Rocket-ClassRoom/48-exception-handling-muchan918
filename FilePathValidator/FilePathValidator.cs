using System;
using System.IO;
using System.Linq;

public class FilePathValidator
{
    public void ValidatePath(string path)
    {
        if (string.IsNullOrEmpty(path))
        {
            throw new ArgumentNullException(nameof(path), "경로는 null이거나 비어있을 수 없습니다.");
        }

        char[] invalidChars = { '<', '>', '|', '"', '*', '?' };

        foreach (char c in invalidChars)
        {
            if (path.Contains(c))
            {
                throw new ArgumentException($"경로에 금지 문자 '{c}'가 포함되어 있습니다.");
            }
        }

        if (path.Length > 260)
        {
            throw new ArgumentOutOfRangeException(nameof(path), "경로 길이가 260자를 초과합니다.");
        }

        Console.WriteLine($"경로가 유효합니다: {path}");
    }

    public void ValidateExtension(string path, string[] allowedExtensions)
    {
        string extension = Path.GetExtension(path);

        if (!allowedExtensions.Contains(extension))
        {
            throw new ArgumentException($"허용되지 않은 확장자입니다: {extension}");
        }

        Console.WriteLine($"확장자가 유효합니다: {extension}");
    }
}