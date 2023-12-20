using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Character", menuName = "Object/Character") ]
public class SOCharacter : SOGachaItem
{
    [Header("Stats")]
    public float BaseAttack;
    public float BaseHP;
    public float BaseDefense;
}
