using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindmillSnapCheck : MonoBehaviour
{
    public enum Part
    {
        TOP,
        MID,
        BOTTOM
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
            case Part.TOP:
                // do this;
                break;
            case Part.MID:
                // do this;
                break;
            case Part.BOTTOM:
                // do this;
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
                //do this;
                break;
            case Era.MODERN:
                //do this;
                break;
            default:
                //do tis if nothing else triggers.
                break;
        }
    }
}
