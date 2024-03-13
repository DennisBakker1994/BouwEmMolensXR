using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingCycle : MonoBehaviour
{
    public GameObject[] builds;

    int buildingStyle;

    public void ChangeIntPlus()
    {
        buildingStyle++;

        if (buildingStyle > 5)
        {
            buildingStyle = 0;
        }

        SetAllToFalse();
        builds[buildingStyle].SetActive(true);
    }

    public void ChangeIntMinus()
    {
        buildingStyle--;

        if (buildingStyle < 0)
        {
            buildingStyle = 5;

        }

        SetAllToFalse();
        builds[buildingStyle].SetActive(true);
    }

    void SetAllToFalse()
    {
        for (int i = 0; i <= builds.Length; i++)
        {
            builds[i - 1].SetActive(false);
        }
    }
}
