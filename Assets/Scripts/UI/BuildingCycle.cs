using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingCycle : MonoBehaviour
{
    public GameObject[] builds;

    public GameObject build1;
    public GameObject build2;
    public GameObject build3;
    public GameObject build4;
    public GameObject build5;
    public GameObject build6;

    int buildingStyle;

    public void ChangeIntPlus()
    {

        if (buildingStyle == 5)
        {
            buildingStyle = 0;
        }

        buildingStyle++;

        SetAllToFalse();
        builds[buildingStyle].SetActive(true);
    }

    public void ChangeIntMinus()
    {

        if (buildingStyle < 0)
        {
            buildingStyle = 5;

        }

        buildingStyle--;

        SetAllToFalse();
        builds[buildingStyle].SetActive(true);
    }

    void SetAllToFalse()
    {
        build1.SetActive(false);
        build2.SetActive(false);
        build3.SetActive(false);
        build4.SetActive(false);
        build5.SetActive(false);
        build6.SetActive(false);
    }
}
