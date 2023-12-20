using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaManager : MonoBehaviour
{
    public List<SOTable> table;
    public List<SOGachaItem> gachaPulled;

    public SOInventory inventory;

    [Header("Gacha Manager")]
    public bool isPulling = false;
    public int manyPull = 0;
    public int indexPulled = 0;


    public void pickTable()
    {
        int rnd = Random.Range(0, 100);
        foreach(var item in table)
        {
            if (item.tableWeight >= rnd)
            {
                print(item.tableRarity);
                pickGacha(item);
                return;
            }
            rnd -= item.tableWeight;
        }
    }

    public void pickGacha(SOTable item)
    {
        int idx = Random.Range(0, item.gachaPool.Count);
        var pull = item.gachaPool[idx];
        print(pull.name);
        gachaPulled.Add(pull);
        inventory.addList(pull);

    }

    public void pullGacha(int amount)
    {
        for(int i = 0; i < amount; i++)
        {
            pickTable();
        }
    }
    
    public void clearPulled()
    {
        gachaPulled.Clear();
    }

}
