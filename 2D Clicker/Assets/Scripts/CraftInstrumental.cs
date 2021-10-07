using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftInstrumental : MonoBehaviour
{
    [SerializeField] private Text[] _uiMaterials;
    [SerializeField] private Text[] _uiNeedMaterialsAxe;
    [SerializeField] private Text[] _uiNeedMaterialsPick;
    [SerializeField] private Text[] _uiLevelsInstrumentalAxe;
    [SerializeField] private Text[] _uiLevelsInstrumentalPick;
    [SerializeField] private PlayerInventory _instruments;

    public void Start()
    {
        UpdateAxeLevel();
        UpdatePickLevel();
    }


    public void CraftAxe()
    {
        int Wood = PlayerPrefs.GetInt("WOOD_COUNT", 0);
        int Stone = PlayerPrefs.GetInt("STONE_COUNT", 0);
        int Iron = PlayerPrefs.GetInt("IRON_COUNT", 0);
        int Gold = PlayerPrefs.GetInt("GOLD_COUNT", 0);

        if (_instruments._axe.GetLevel() == 1 && Wood >= 50 && Stone >= 20)
        {
            Wood -= 50;
            Stone -= 20;
            PlayerPrefs.SetInt("WOOD_COUNT", Wood);
            PlayerPrefs.SetInt("STONE_COUNT", Stone);
            SetUIMaterials(Wood, Stone, Iron, Gold);
            UpdateAxeInstrumental();
            SetNeedMaterialsAxe(100, 50, 20, 0);
            UpdateAxeLevel();

        }
        if(_instruments._axe.GetLevel() == 2 && Wood >= 100 && Stone >= 50 && Iron >= 20)
        {
            Wood -= 100;
            Stone -= 50;
            Iron -= 20;
            PlayerPrefs.SetInt("WOOD_COUNT", Wood);
            PlayerPrefs.SetInt("STONE_COUNT", Stone);
            PlayerPrefs.SetInt("IRON_COUNT", Iron);
            SetUIMaterials(Wood, Stone, Iron, Gold);
            UpdateAxeInstrumental();
            SetNeedMaterialsAxe(150, 100, 50, 20);
            UpdateAxeLevel();
        }
        if(_instruments._axe.GetLevel() == 3 && Wood >= 150 && Stone >= 100 && Iron >= 50 && Gold >= 20)
        {
            Wood -= 150;
            Stone -= 100;
            Iron -= 50;
            Gold -= 20;
            PlayerPrefs.SetInt("WOOD_COUNT", Wood);
            PlayerPrefs.SetInt("STONE_COUNT", Stone);
            PlayerPrefs.SetInt("IRON_COUNT", Iron);
            PlayerPrefs.SetInt("GOLD_COUNT", Gold);
            SetUIMaterials(Wood, Stone, Iron, Gold);
            UpdateAxeInstrumental();
            SetNeedMaterialsAxe(200, 150, 100, 50);
            UpdateAxeLevel();
        }
        if(_instruments._axe.GetLevel() == 4 && Wood >= 200 && Stone >= 150 && Iron >= 100 && Gold >= 50)
        {
            Wood -= 200;
            Stone -= 150;
            Iron -= 100;
            Gold -= 50;
            PlayerPrefs.SetInt("WOOD_COUNT", Wood);
            PlayerPrefs.SetInt("STONE_COUNT", Stone);
            PlayerPrefs.SetInt("IRON_COUNT", Iron);
            PlayerPrefs.SetInt("GOLD_COUNT", Gold);
            SetUIMaterials(Wood, Stone, Iron, Gold);
            UpdateAxeInstrumental();
            SetNeedMaterialsAxe(300, 300, 300, 300);
            UpdateAxeLevel();
        }
        if(_instruments._axe.GetLevel() == 5 && Wood >= 300 && Stone >= 300 && Iron >= 300 && Gold >= 300)
        {
            Wood -= 300;
            Stone -= 300;
            Iron -= 300;
            Gold -= 300;
            PlayerPrefs.SetInt("WOOD_COUNT", Wood);
            PlayerPrefs.SetInt("STONE_COUNT", Stone);
            PlayerPrefs.SetInt("IRON_COUNT", Iron);
            PlayerPrefs.SetInt("GOLD_COUNT", Gold);
            SetUIMaterials(Wood, Stone, Iron, Gold);
            UpdateAxeInstrumental();
            SetNeedMaterialsAxe(0, 0, 0, 0);
            UpdateAxeLevel();
        }
    }

    public void CraftPick()
    {
        int Wood = PlayerPrefs.GetInt("WOOD_COUNT", 0);
        int Stone = PlayerPrefs.GetInt("STONE_COUNT", 0);
        int Iron = PlayerPrefs.GetInt("IRON_COUNT", 0);
        int Gold = PlayerPrefs.GetInt("GOLD_COUNT", 0);

        if (_instruments._pick.GetLevel() == 0 && Wood >= 50 && Stone >= 20)
        {
            Wood -= 50;
            Stone -= 20;
            PlayerPrefs.SetInt("WOOD_COUNT", Wood);
            PlayerPrefs.SetInt("STONE_COUNT", Stone);
            SetUIMaterials(Wood, Stone, Iron, Gold);
            UpdatePickInstrumental();
            SetNeedMaterialsPick(100, 50, 20, 0);
            UpdatePickLevel();

        }
        if (_instruments._pick.GetLevel() == 1 && Wood >= 100 && Stone >= 50 && Iron >= 20)
        {
            Wood -= 100;
            Stone -= 50;
            Iron -= 20;
            PlayerPrefs.SetInt("WOOD_COUNT", Wood);
            PlayerPrefs.SetInt("STONE_COUNT", Stone);
            PlayerPrefs.SetInt("IRON_COUNT", Iron);
            SetUIMaterials(Wood, Stone, Iron, Gold);
            UpdatePickInstrumental();
            SetNeedMaterialsPick(150, 100, 50, 20);
            UpdatePickLevel();
        }
        if (_instruments._pick.GetLevel() == 2 && Wood >= 150 && Stone >= 100 && Iron >= 50 && Gold >= 20)
        {
            Wood -= 150;
            Stone -= 100;
            Iron -= 50;
            Gold -= 20;
            PlayerPrefs.SetInt("WOOD_COUNT", Wood);
            PlayerPrefs.SetInt("STONE_COUNT", Stone);
            PlayerPrefs.SetInt("IRON_COUNT", Iron);
            PlayerPrefs.SetInt("GOLD_COUNT", Gold);
            SetUIMaterials(Wood, Stone, Iron, Gold);
            UpdatePickInstrumental();
            SetNeedMaterialsPick(200, 150, 100, 50);
            UpdatePickLevel();
        }
        if (_instruments._pick.GetLevel() == 3 && Wood >= 200 && Stone >= 150 && Iron >= 100 && Gold >= 50)
        {
            Wood -= 200;
            Stone -= 150;
            Iron -= 100;
            Gold -= 50;
            PlayerPrefs.SetInt("WOOD_COUNT", Wood);
            PlayerPrefs.SetInt("STONE_COUNT", Stone);
            PlayerPrefs.SetInt("IRON_COUNT", Iron);
            PlayerPrefs.SetInt("GOLD_COUNT", Gold);
            SetUIMaterials(Wood, Stone, Iron, Gold);
            UpdatePickInstrumental();
            SetNeedMaterialsPick(300, 300, 300, 300);
            UpdatePickLevel();
        }
        if (_instruments._pick.GetLevel() == 4 && Wood >= 300 && Stone >= 300 && Iron >= 300 && Gold >= 300)
        {
            Wood -= 300;
            Stone -= 300;
            Iron -= 300;
            Gold -= 300;
            PlayerPrefs.SetInt("WOOD_COUNT", Wood);
            PlayerPrefs.SetInt("STONE_COUNT", Stone);
            PlayerPrefs.SetInt("IRON_COUNT", Iron);
            PlayerPrefs.SetInt("GOLD_COUNT", Gold);
            SetUIMaterials(Wood, Stone, Iron, Gold);
            UpdatePickInstrumental();
            SetNeedMaterialsPick(0, 0, 0, 0);
            UpdatePickLevel();
        }
    }

    public void SetNeedMaterialsAxe(int wood, int stone, int iron, int gold)
    {
        _uiNeedMaterialsAxe[0].text = wood.ToString();
        _uiNeedMaterialsAxe[1].text = stone.ToString();
        _uiNeedMaterialsAxe[2].text = iron.ToString();
        _uiNeedMaterialsAxe[3].text = gold.ToString();
    }

    private void UpdateAxeLevel()
    {
        _uiLevelsInstrumentalAxe[0].text = _instruments._axe.GetLevel().ToString();
        _uiLevelsInstrumentalAxe[1].text = _instruments._axe.GetLevel().ToString();
        if (_instruments._axe.GetLevel() == 1)
        {
            SetNeedMaterialsAxe(50, 20, 0, 0);
            _uiLevelsInstrumentalAxe[0].text = _instruments._axe.GetLevel().ToString();
            _uiLevelsInstrumentalAxe[1].text = (_instruments._axe.GetLevel() + 1).ToString();
        }
        else if (_instruments._axe.GetLevel() == 2)
        {
            SetNeedMaterialsAxe(100, 50, 20, 0);
            _uiLevelsInstrumentalAxe[0].text = _instruments._axe.GetLevel().ToString();
            _uiLevelsInstrumentalAxe[1].text = (_instruments._axe.GetLevel() + 1).ToString();
        }
        else if (_instruments._axe.GetLevel() == 3)
        {
            SetNeedMaterialsAxe(150, 100, 50, 20);
            _uiLevelsInstrumentalAxe[0].text = _instruments._axe.GetLevel().ToString();
            _uiLevelsInstrumentalAxe[1].text = (_instruments._axe.GetLevel() + 1).ToString();
        }
        else if (_instruments._axe.GetLevel() == 4)
        {
            SetNeedMaterialsAxe(200, 150, 100, 50);
            _uiLevelsInstrumentalAxe[0].text = _instruments._axe.GetLevel().ToString();
            _uiLevelsInstrumentalAxe[1].text = (_instruments._axe.GetLevel() + 1).ToString();
        }
        else if (_instruments._axe.GetLevel() == 5)
        {
            SetNeedMaterialsAxe(300, 300, 300, 300);
            _uiLevelsInstrumentalAxe[0].text = _instruments._axe.GetLevel().ToString();
            _uiLevelsInstrumentalAxe[1].text = (_instruments._axe.GetLevel() + 1).ToString();
        }
        else if (_instruments._axe.GetLevel() >= 6)
        {
            _uiLevelsInstrumentalAxe[0].text = "MAX";
            _uiLevelsInstrumentalAxe[1].text = "MAX";
        }
    }

    public void UpdateAxeInstrumental()
    {
        _instruments._axe.AddLevel();
        _instruments._axe.SetData();
        _instruments._axe.GetData();
    }

    public void UpdatePickLevel()
    {
        _uiLevelsInstrumentalPick[0].text = _instruments._pick.GetLevel().ToString();
        _uiLevelsInstrumentalPick[1].text = _instruments._pick.GetLevel().ToString();



        if (_instruments._pick.GetLevel() == 0)
        {
            SetNeedMaterialsPick(50, 20, 0, 0);
            _uiLevelsInstrumentalPick[0].text = _instruments._pick.GetLevel().ToString();
            _uiLevelsInstrumentalPick[1].text = (_instruments._pick.GetLevel() + 1).ToString();
        }
        else if (_instruments._pick.GetLevel() == 1)
        {
            SetNeedMaterialsPick(100, 50, 20, 0);
            _uiLevelsInstrumentalPick[0].text = _instruments._pick.GetLevel().ToString();
            _uiLevelsInstrumentalPick[1].text = (_instruments._pick.GetLevel() + 1).ToString();
        }
        else if (_instruments._pick.GetLevel() == 2)
        {
            SetNeedMaterialsPick(150, 100, 50, 20);
            _uiLevelsInstrumentalPick[0].text = _instruments._pick.GetLevel().ToString();
            _uiLevelsInstrumentalPick[1].text = (_instruments._pick.GetLevel() + 1).ToString();
        }
        else if (_instruments._pick.GetLevel() == 3)
        {
            SetNeedMaterialsPick(200, 150, 100, 50);
            _uiLevelsInstrumentalPick[0].text = _instruments._pick.GetLevel().ToString();
            _uiLevelsInstrumentalPick[1].text = (_instruments._pick.GetLevel() + 1).ToString();
        }
        else if (_instruments._pick.GetLevel() == 4)
        {
            SetNeedMaterialsPick(300, 300, 300, 300);
            _uiLevelsInstrumentalPick[0].text = _instruments._pick.GetLevel().ToString();
            _uiLevelsInstrumentalPick[1].text = (_instruments._pick.GetLevel() + 1).ToString();
        }
        else if (_instruments._pick.GetLevel() >= 5)
        {
            _uiLevelsInstrumentalPick[0].text = "MAX";
            _uiLevelsInstrumentalPick[1].text = "MAX";
        }
    }

    public void SetUIMaterials(int wood, int stone, int iron, int gold)
    {
        _uiMaterials[0].text = wood.ToString();
        _uiMaterials[1].text = stone.ToString();
        _uiMaterials[2].text = iron.ToString();
        _uiMaterials[3].text = gold.ToString();
    }
    
    public void SetNeedMaterialsPick(int wood, int stone, int iron, int gold)
    {
        _uiNeedMaterialsPick[0].text = wood.ToString();
        _uiNeedMaterialsPick[1].text = stone.ToString();
        _uiNeedMaterialsPick[2].text = iron.ToString();
        _uiNeedMaterialsPick[3].text = gold.ToString();
    }

    public void UpdatePickInstrumental()
    {
        _instruments._pick.AddLevel();
        _instruments._pick.SetData();
        _instruments._pick.GetData();
    }
}
