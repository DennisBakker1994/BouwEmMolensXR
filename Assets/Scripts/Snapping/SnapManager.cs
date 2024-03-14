using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapManager : MonoBehaviour
{
    [Header("Variable")]
    public bool canSnap;
    public GameObject parentToSnap;
    public GameObject snappingPoint;

    private void OnTriggerEnter(Collider other)
    {
        CheckIfCanSnap(other.gameObject.GetComponent<WindmillInformation>());
        AllowSnapPartTraditional(other.gameObject.GetComponent<WindmillInformation>());
        AllowSnapPartModern(other.gameObject.GetComponent<WindmillInformation>());
    }

    public void CheckIfCanSnap(WindmillInformation partCheck)
    {
        canSnap = false;
        switch (partCheck.part)
        {
            case WindmillInformation.Part.TOP:
                if (WindmillInformation.Part.BOTTOM == partCheck.part)
                {
                    Debug.Log("Can Snap.");
                    canSnap = true;

                }
                break;
            case WindmillInformation.Part.WINDMILLBLADES:
                if (WindmillInformation.Part.TOP == partCheck.part)
                {
                    Debug.Log("Can Snap.");
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
                Debug.Log("Snapped");
                gameObject.transform.position = snappingPoint.transform.position;
                parentToSnap.transform.SetParent(gameObject.transform);
            }
        }
    }

    public void AllowSnapPartModern(WindmillInformation eraCheck)
    {
        if (WindmillInformation.Era.MODERN == eraCheck.era)
        {
            if (canSnap == true)
            {
                Debug.Log("Snapped");
                gameObject.transform.position = snappingPoint.transform.position;
                parentToSnap.transform.SetParent(gameObject.transform);
            }
        }
    }
}
