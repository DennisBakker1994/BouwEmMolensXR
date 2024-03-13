using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WindmillInformation : MonoBehaviour
{
    public enum Part
    {
        BOTTOM,
        TOP,
        WINDMILLBLADES
    }

    public Part part;

    public enum Era
    {
        TRADITIONAL,
        MODERN
    }

    public Era era;

    [Header("Variables")]
    public bool canSnap;


    public void CheckIfCanSnap()
    {
        canSnap = false;
        switch (part)
        {
            case Part.TOP:
                if (Part.BOTTOM == part)
                {
                    canSnap = true;
                }
                break;
            case Part.WINDMILLBLADES:
                if (Part.TOP == part)
                {
                    canSnap = true;
                }
                break;
            default:
                // do this if nothing else triggers.
                break;
        }
    }

    public void AllowSnapPartTraditional()
    {
        if (Era.TRADITIONAL == era)
        {
            if (canSnap == true)
            {
                //AllowSnappingToHappen
            }
        }
    }

    public void AllowSnapPartModern()
    {
        if (Era.MODERN == era)
        {
            if (canSnap == true)
            {
                //AllowSnappingToHappen
            }
        }
    }
}
