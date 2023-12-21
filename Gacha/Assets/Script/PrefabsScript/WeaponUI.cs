using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WeaponUI : MonoBehaviour
{
    public Image imageWeapon;
    public TextMeshProUGUI nameWeapon;
    public TextMeshProUGUI rarityWeapon;
    public TextMeshProUGUI attack;
    public TextMeshProUGUI specialEffect;

    public void showUI(Sprite image, string name, string rarity, float atk, string special)
    {
        imageWeapon.sprite = image;
        nameWeapon.text = name;
        rarityWeapon.text = rarity;
        attack.text = atk.ToString();
        specialEffect.text = special;
    }
}
