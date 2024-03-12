using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingCycle : MonoBehaviour
{
    public GameObject[] builds;

    int buildingStyle;
    int i;

    private void Update()
    {
        SwitchBuildStyle();
    }

    public void ChangeIntPlus()
    {
        buildingStyle++;

        if (buildingStyle > 5)
        {
            buildingStyle = 0;
            i = 0;
        } 
    }

    public void ChangeIntMinus()
    {
        buildingStyle--;

        if (buildingStyle < 0)
        {
            buildingStyle = 5;
            i = 5;

        }
    }

    public void SwitchBuildStyle()
    {
        SetAllToFalse();
        builds[buildingStyle].SetActive(true);
    }

    void SetAllToFalse()
    {
        for (i = 0; i < buildingStyle; i++)
        {
            builds[i].SetActive(false);
        }
    }
}
