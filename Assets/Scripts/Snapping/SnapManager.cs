using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapManager : MonoBehaviour
{
    //[Header("Part Enums")]
    //WindmillInformation.Part bottomPart = WindmillInformation.Part.BOTTOM;
    //WindmillInformation.Part topPart = WindmillInformation.Part.TOP;
    //WindmillInformation.Part windmillBladePart = WindmillInformation.Part.WINDMILLBLADES;

    //[Header("Era Enums")]
    //WindmillInformation.Era traditionalEra = WindmillInformation.Era.TRADITIONAL;
    //WindmillInformation.Era modernEra = WindmillInformation.Era.MODERN;

    [Header("Variable")]
    public bool canSnap;

    public void CheckIfCanSnap(WindmillInformation windmillInformation)
    {
        canSnap = false;
        switch (windmillInformation.part)
        {
            case WindmillInformation.Part.TOP:
                if (WindmillInformation.Part.BOTTOM == windmillInformation.part)
                {
                    canSnap = true;
                }
                break;
            case WindmillInformation.Part.WINDMILLBLADES:
                if (WindmillInformation.Part.TOP == windmillInformation.part)
                {
                    canSnap = true;
                }
                break;
            default:
                // do this if nothing else triggers.
                break;
        }
    }
}
