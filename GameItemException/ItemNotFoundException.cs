using System;

class ItemNotFoundException : Exception
{
    public string ItemName { get; }

    // 기본 생성자
    public ItemNotFoundException()
        : base("유효하지 않은 플레이어입니다.")
    {
    }

    // 메시지를 받는 생성자
    public ItemNotFoundException(string message)
        : base(message)
    {
    }

    // 메시지와 내부 예외를 받는 생성자
    public ItemNotFoundException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}