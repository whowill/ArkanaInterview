using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InventoryManager : MonoBehaviour
{
    public SOInventory bag;
    //public List<GameObject> inventory;
    public GameObject prefabsWeapon;
    public GameObject prefabsCharacter;
    public RectTransform inventoryContent;


    private void Start()
    {
        getInven();
    }

    public void getInven()
    {
        if(bag.inventory.Count == 0)
        {
            print("kosong");
            return;
        }
        foreach(var item in bag.inventory)
        {
            if(item is SOWeapon)
            {
                SOWeapon weapon = item as SOWeapon;
                GameObject obj = Instantiate(prefabsWeapon, Vector3.zero, Quaternion.identity);
                obj.transform.SetParent(inventoryContent, false);
                obj.GetComponent<WeaponUI>().showUI(item.Image, item.Name, item.rarity, weapon.BaseAttack, weapon.SpecialEffect);
                //inventory.Add(obj);
            }
            if(item is SOCharacter)
            {
                SOCharacter character = item as SOCharacter;
                GameObject obj = Instantiate(prefabsCharacter, Vector3.zero, Quaternion.identity);
                obj.transform.SetParent(inventoryContent, false);
                obj.GetComponent<CharacterUI>().showUI(item.Image, item.Name, item.rarity, character.BaseAttack, character.BaseHP, character.BaseDefense);
                //inventory.Add(obj);
            }
        }
    }

    public void backButton()
    {
        SceneManager.LoadScene(0);
    }
}
