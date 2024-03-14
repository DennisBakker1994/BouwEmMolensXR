using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapManager : MonoBehaviour
{
    [Header("Variable")]
    public bool canSnap;
    public GameObject parentToSnap;
    public GameObject snappingPoint;
    public Transform transformToSnap;

    public WindmillInformation.Part otherPart;
    public WindmillInformation.Era otherEra;

    private void OnTriggerEnter(Collider other)
    {

        otherPart = other.gameObject.GetComponentInParent<WindmillInformation>().part;
        otherEra = other.gameObject.GetComponentInParent<WindmillInformation>().era;
        transformToSnap = other.gameObject.transform;
        CheckIfCanSnap();
    }

    public void CheckIfCanSnap()
    {
        Debug.Log("Trying to Snap");
        canSnap = false;

        if (this.GetComponentInParent<WindmillInformation>().part == WindmillInformation.Part.BOTTOM && otherPart == WindmillInformation.Part.TOP)
        {
            Debug.Log("Can Snap.");
            canSnap = true;
           
            if (this.GetComponentInParent<WindmillInformation>().era == WindmillInformation.Era.TRADITIONAL)
            {
                AllowSnapPartTraditional();
            }
        }
    }

    public void AllowSnapPartTraditional()
    {
        if (otherEra == WindmillInformation.Era.TRADITIONAL)
        {
            if (canSnap == true)
            {
                Debug.Log(transformToSnap.GetComponent<Rigidbody>().isKinematic);
                transformToSnap.transform.position = snappingPoint.transform.position;
                transformToSnap.GetComponent<Rigidbody>().isKinematic = true;
                parentToSnap.transform.SetParent(gameObject.transform);
            }
        }
        else
        {
            Debug.Log("Wrong Era");
            canSnap = false;
        }
    }

    public void AllowSnapPartModern(WindmillInformation eraCheck)
    {
        if (WindmillInformation.Era.MODERN == eraCheck.era)
        {
            if (canSnap == true)
            {
                transformToSnap.GetComponent<Rigidbody>().isKinematic = true;
                Debug.Log(transformToSnap.GetComponent<Rigidbody>().isKinematic);
                gameObject.transform.position = snappingPoint.transform.position;
                parentToSnap.transform.SetParent(gameObject.transform);
            }
        }
    }
}
