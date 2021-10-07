using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyMaterials : MonoBehaviour
{
    [SerializeField] private Text[] _uiMaterials;

    public void Buy(int i)
    {
        switch (i) 
        {
            case 0:
                Buy("WOOD_COUNT", "STONE_COUNT", 0, 1);
                break;
            case 1:
                Buy("STONE_COUNT", "IRON_COUNT", 1, 2);
                break;
            case 2:
                Buy("IRON_COUNT", "GOLD_COUNT", 2, 3);
                break;
            case 3:
                Buy("GOLD_COUNT", "STONE_COUNT", 3, 1);
                break;
            case 4:
                Buy("GOLD_COUNT", "IRON_COUNT", 3, 2);
                break;
        }
    }

    public void Buy(string keySale, string keyBuy, int uiSale, int uiBuy)
    {
        int saleMaterial = PlayerPrefs.GetInt(keySale);
        int buyMaterial = PlayerPrefs.GetInt(keyBuy);
        if (saleMaterial >= 10)
        {
            saleMaterial -= 10;
            buyMaterial += 1;
            PlayerPrefs.SetInt(keySale, saleMaterial);
            PlayerPrefs.SetInt(keyBuy, buyMaterial);
            _uiMaterials[uiSale].text = saleMaterial.ToString();
            _uiMaterials[uiBuy].text = buyMaterial.ToString();
        }
    }
}
