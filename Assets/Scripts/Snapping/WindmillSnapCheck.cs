using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindmillSnapCheck : MonoBehaviour
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


    public void CheckIfCanSnap()
    {
        switch (part)
        {
            case Part.BOTTOM:
                //do this;
                break;
            case Part.TOP:
                //if (Part.BOTTOM == part)
                //{
                //    canSnap;
                //}
                //else
                //{
                //    !canSnap;
                //}
                break;
            case Part.WINDMILLBLADES:
                //if (Part.TOP == part)
                //{
                //    canSnap;
                //}
                //else
                //{
                //    !canSnap;
                //}
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
                //if (Era.TRADITIONAL == era)
                //{
                //    canSnap;
                //}
                //else
                //{
                //    !canSnap;
                //}
                break;
            case Era.MODERN:
                //if (Era.MODERN == era)
                //{
                //    canSnap;
                //}
                //else
                //{
                //    !canSnap;
                //}
                break;
            default:
                //do tis if nothing else triggers.
                break;
        }
    }
}
