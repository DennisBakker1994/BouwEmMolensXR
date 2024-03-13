using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindmillSnapCheck : MonoBehaviour
{
    public enum Part
    {
        PLACEMENT,
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
    public bool isSameEra;


    public void CheckIfCanSnap()
    {
        switch (part)
        {
            case Part.BOTTOM:
                if (Part.PLACEMENT == part)
                {
                    canSnap = true;
                }
                else
                {
                    canSnap = false;
                }
                break;
            case Part.TOP:
                if (Part.BOTTOM == part)
                {
                    canSnap = true;
                }
                else
                {
                    canSnap = false;
                }
                break;
            case Part.WINDMILLBLADES:
                if (Part.TOP == part)
                {
                    canSnap = true;
                }
                else
                {
                    canSnap = false;
                }
                break;
            default:
                // do this if nothing else triggers.
                break;
        }
    }

    public void CheckWhatEra()
    {
        switch (era)
        {
            case Era.TRADITIONAL:
                if (Era.TRADITIONAL == era)
                {
                    isSameEra = true;
                }
                else
                {
                    isSameEra = false;
                }
                break;
            case Era.MODERN:
                if (Era.MODERN == era)
                {
                    isSameEra = true;
                }
                else
                {
                    isSameEra = false;
                }
                break;
            default:
                //do this if nothing else triggers.
                break;
        }
    }

    public void AllowSnapPart()
    {
        if (isSameEra == true)
        {
            if (canSnap == true)
            {
                //AllowSnappingToHappen
            }
        }
    }
}
