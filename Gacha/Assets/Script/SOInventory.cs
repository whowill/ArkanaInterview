using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "inventory", menuName ="Object/Inventory")]
public class SOInventory : ScriptableObject
{
    public List<SOGachaItem> inventory;

    public void addList(SOGachaItem item)
    {
        inventory.Add(item);
    }
}
