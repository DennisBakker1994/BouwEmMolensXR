using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditMode : MonoBehaviour
{
    public GameObject[] windmillsToManipulate;

    private void Start()
    {
        windmillsToManipulate = GameObject.FindGameObjectsWithTag("Windmill");
    }

    public void CheckIfBuildMode()
    {
        bool canBuildMode = GetComponentInChildren<SnapManager>().canBuildMode;

        if (canBuildMode == true)
        {
            ActivateBuildMode();
        }
    }

    public void ActivateBuildMode()
    {

    }

    public void WindmillScaling()
    {

    }
}
