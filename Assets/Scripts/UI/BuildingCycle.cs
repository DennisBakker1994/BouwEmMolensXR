using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingCycle : MonoBehaviour
{
    public GameObject[] builds;

    int buildingStyle;

    private void Update()
    {
        SwitchBuildStyle();
    }

    public void ChangeIntPlus()
    {
        buildingStyle++;

        if (buildingStyle > 5)
        {
            buildingStyle = 1;
        } 
    }

    public void ChangeIntMinus()
    {
        buildingStyle--;

        if (buildingStyle < 0)
        {
            buildingStyle = 6;
        }
    }

    public void SwitchBuildStyle()
    {
        SetAllToFalse();
        builds[buildingStyle].SetActive(true);
    }

    void SetAllToFalse()
    {
        for (int i = 0; i < buildingStyle; i++)
        {
            builds[i].SetActive(false);
        }
    }
}
