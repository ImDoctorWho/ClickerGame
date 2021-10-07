using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject[] _materialsCanvas;
    [SerializeField] private GameObject _mainMenuCanvas;
    [SerializeField] private GameObject[] _magazineCanvas;

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

    public void CloseMagazine(int i)
    {
        _magazineCanvas[i].SetActive(false);
        _mainMenuCanvas.SetActive(true);
    }
    public void OpenMagazine(int i)
    {
        _magazineCanvas[i].SetActive(true);
        _mainMenuCanvas.SetActive(false);
    }
}
