using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public Axe _axe;
    public Pick _pick;
    public HomeBuilding _home;
    public WorkshopBildings _workshop;

    private void Awake()
    {

        _axe = new Axe("AXE_LEVEL", 1);
        _pick = new Pick("PICK_LEVEL", 0);
        _home = new HomeBuilding("HOME_LEVEL", 0);
        _workshop = new WorkshopBildings("WORKSHOP_LEVEL", 0);

        _axe.GetData();
        _pick.GetData();
        _home.GetData();
        _workshop.GetData();
    }
}
