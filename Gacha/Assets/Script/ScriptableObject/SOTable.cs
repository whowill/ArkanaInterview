using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Table", menuName = "Object/Table")]
public class SOTable : ScriptableObject
{
    public string tableRarity;
    public int tableWeight;
    public List<SOGachaItem> gachaPool;
}
