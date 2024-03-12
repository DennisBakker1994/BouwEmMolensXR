using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingCycle : MonoBehaviour
{
    public GameObject build1;
    public GameObject build2;
    public GameObject build3;
    public GameObject build4;
    public GameObject build5;
    public GameObject build6;

    int buildingStyle;

    public void ChangeIntPlus()
    {
        buildingStyle++;

        if (buildingStyle > 6)
        {
            buildingStyle = 1;
        } 
    }

    public void ChangeIntMinus()
    {
        buildingStyle--;

        if (buildingStyle < 1)
        {
            buildingStyle = 6;
        }
    }
}
