using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIMain : MonoBehaviour
{
    public Image backGround;
    public Image GachaImage;
    public TextMeshProUGUI rarityText;

    public Button nextOrInven;
    public TextMeshProUGUI textNextOrInvent;
    public Button onePull;
    public Button tenPull;

    public GachaManager manager;

    private void Start()
    {
        check();
    }

    public void pull(int amount)
    {
        manager.manyPull = amount;
        manager.isPulling = true;
        check();
        manager.pullGacha(amount);
        showGacha(manager.indexPulled);
    }

    public void check()
    {
        if(manager.isPulling == true)
        {
            textNextOrInvent.text = "next";
            onePull.interactable = false;
            tenPull.interactable = false;
        }
        else
        {
            textNextOrInvent.text = "Inventory";
            onePull.interactable = true;
            tenPull.interactable = true;
        }
    }

    public void nextButton()
    {
        if(manager.isPulling == true)
        {
            manager.indexPulled++;
            if(manager.indexPulled == manager.manyPull)
            {
                manager.indexPulled = 0;
                manager.manyPull = 0;
                manager.isPulling = false;
                manager.clearPulled();
                check();
                return;
            }
            showGacha(manager.indexPulled);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }

    public void showGacha(int index)
    {
        if(manager.gachaPulled[index].rarity == "SuperRare")
        {
            backGround.color = new Color32(162, 0, 109, 255);
        }else if(manager.gachaPulled[index].rarity == "Rare")
        {
            backGround.color = new Color32(247,127,190, 255);
        }
        else
        {
            backGround.color = new Color32(174, 152, 170, 255);
        }
        GachaImage.sprite = manager.gachaPulled[index].Image;
        rarityText.text = manager.gachaPulled[index].rarity;
    }
}
