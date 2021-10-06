using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetMaterials : MonoBehaviour
{
    private enum Materials
    {
        Wood,
        Stone,
        Iron,
        Gold
    }

    [SerializeField] private Materials _material;
    [SerializeField] private Text _countMaterialsUI;
    [SerializeField] private string[] _namesMaterials;
    [SerializeField] private PlayerInventory _playerInventory;
    [SerializeField] private bool _isReadyMining;


    public void MiningMaterials()
    {
        CheckLevel();
        if (_isReadyMining)
        {
            string Key = _namesMaterials[((int)_material)] + "_COUNT";
            int countM = PlayerPrefs.GetInt(Key, 0);
            countM++;
            PlayerPrefs.SetInt(Key, countM);
            _countMaterialsUI.text = countM.ToString();
            _isReadyMining = false;
        }
    }

    public void CheckLevel()
    {
        if ((int)_material == 0 && _playerInventory._axe.GetLevel() > 0)
        {
            _isReadyMining = true;
        }
        if ((int)_material == 1 && _playerInventory._pick.GetLevel() > 0)
        {
            _isReadyMining = true;
            
        }
        if ((int)_material == 2 && _playerInventory._pick.GetLevel() > 1)
        {
            _isReadyMining = true;
        }
        if ((int)_material == 3 && _playerInventory._pick.GetLevel() > 2)
        {
            _isReadyMining = true;
        }
    }
}
