using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InizializedGame : MonoBehaviour
{
    [SerializeField] private Text[] _countsMaterials;

    public void Awake()
    {
        _countsMaterials[0].text = PlayerPrefs.GetInt("WOOD_COUNT", 0).ToString();
        _countsMaterials[1].text = PlayerPrefs.GetInt("STONE_COUNT", 0).ToString();
        _countsMaterials[2].text = PlayerPrefs.GetInt("IRON_COUNT", 0).ToString();
        _countsMaterials[3].text = PlayerPrefs.GetInt("GOLD_COUNT", 0).ToString();
    }
}
