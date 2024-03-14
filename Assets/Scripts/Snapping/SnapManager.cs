using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapManager : MonoBehaviour
{
    [Header("Variable")]
    public bool canSnap;

    public void CheckIfCanSnap(WindmillInformation partCheck)
    {
        canSnap = false;
        switch (partCheck.part)
        {
            case WindmillInformation.Part.TOP:
                if (WindmillInformation.Part.BOTTOM == partCheck.part)
                {
                    canSnap = true;
                }
                break;
            case WindmillInformation.Part.WINDMILLBLADES:
                if (WindmillInformation.Part.TOP == partCheck.part)
                {
                    canSnap = true;
                }
                break;
            default:
                // do this if nothing else triggers.
                break;
        }
    }

    public void AllowSnapPartTraditional(WindmillInformation eraCheck)
    {
        if (WindmillInformation.Era.TRADITIONAL == eraCheck.era)
        {
            if (canSnap == true)
            {
                //AllowSnappingToHappen
            }
        }
    }

    public void AllowSnapPartModern(WindmillInformation eraCheck)
    {
        if (WindmillInformation.Era.MODERN == eraCheck.era)
        {
            if (canSnap == true)
            {
                //AllowSnappingToHappen
            }
        }
    }
}
