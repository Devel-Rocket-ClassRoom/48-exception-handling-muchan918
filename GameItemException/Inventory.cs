using System;
using System.Collections.Generic;

public class Inventory
{
    private int maxCapacity;
    private List<string> items;

    public Inventory(int maxCapacity)
    {
        this.maxCapacity = maxCapacity;
        items = new List<string>();
    }

    public void AddItem(string itemName)
    {
        if (items.Count == maxCapacity)
        {
            throw new InventoryFullException($"[인벤토리 오류] 인벤토리가 가득 찼습니다. (용량: {maxCapacity}, 아이템: {itemName})");
        }
        items.Add(itemName);
        Console.WriteLine($"아이템 '{itemName}' 추가됨");
    }

    public void RemoveItem(string itemName)
    {
        if(!items.Contains(itemName))
        {
            throw new ItemNotFoundException($"[인벤토리 오류] 아이템을 찾을 수 없습니다: {itemName}");
        }
        items.Remove(itemName);
        Console.WriteLine($"아이템 '{itemName}' 제거됨");
    }

    public void ShowItems()
    {
        Console.WriteLine($"현재 인벤토리: {string.Join(", ", items)}");
    }
}