using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterUI : MonoBehaviour
{
    public Image imageChar;
    public TextMeshProUGUI nameChar;
    public TextMeshProUGUI rarityChar;
    public TextMeshProUGUI attack;
    public TextMeshProUGUI HealthPoint;
    public TextMeshProUGUI Defense;

    public void showUI(Sprite image, string name , string rarity, float atk, float hp, float def)
    {
        imageChar.sprite = image;
        nameChar.text = name;
        rarityChar.text = rarity;
        attack.text = atk.ToString();
        HealthPoint.text = hp.ToString();
        Defense.text = def.ToString();
    }
}
