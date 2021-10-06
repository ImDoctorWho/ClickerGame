using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject[] _materialsCanvas;
    [SerializeField] private GameObject _mainMenuCanvas;

    public void ClickMaterialsButton()
    {
        _mainMenuCanvas.SetActive(false);
        _materialsCanvas[0].SetActive(true);
    }

    public void GoToNewMaterial(int i)
    {
        _materialsCanvas[i].SetActive(true);
    }

    public void GoHome()
    {
        _mainMenuCanvas.SetActive(true);
    }
}
