using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName ="Object/Weapon")]
public class SOWeapon : SOGachaItem
{
    [Header("stats")]
    public float BaseAttack;
    public string SpecialEffect;
}
