using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public Axe _axe;
    public Pick _pick;

    private void Awake()
    {
        int axeLevel = PlayerPrefs.GetInt("AXE_LEVEL", 1);
        int axeMultiple = PlayerPrefs.GetInt("AXE_MULTIPLE", 1);

        int pickLevel = PlayerPrefs.GetInt("PICK_LEVEL", 0);
        int pickMultiple = PlayerPrefs.GetInt("PICK_MULTIPLE", 0);

        _axe = new Axe(axeLevel, axeMultiple);

        _pick = new Pick(pickLevel, pickMultiple);
    }
}
