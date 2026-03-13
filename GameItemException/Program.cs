using System;
using System.Collections.Generic;

Console.WriteLine("=== 인벤토리 테스트 ===");
Inventory inventory = new Inventory(3);
try
{
    inventory.AddItem("검");
    inventory.AddItem("방패");
    inventory.AddItem("포션");
    inventory.AddItem("활");
}
catch (InventoryFullException ife)
{
    Console.WriteLine(ife.Message);
}

Console.WriteLine();

try
{
    inventory.ShowItems();
    inventory.RemoveItem("포션");
    inventory.RemoveItem("도끼");
}
catch(ItemNotFoundException infe)
{
    Console.WriteLine(infe.Message); 
}

Console.WriteLine();
inventory.ShowItems();