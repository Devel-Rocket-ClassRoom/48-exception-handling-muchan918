using System;

class InventoryFullException : Exception
{
    public int Capacity { get; }
    public string ItemName { get; }

    // 기본 생성자
    public InventoryFullException()
        : base("유효하지 않은 플레이어입니다.")
    {
    }

    // 메시지를 받는 생성자
    public InventoryFullException(string message)
        : base(message)
    {
    }

    // 메시지와 내부 예외를 받는 생성자
    public InventoryFullException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}