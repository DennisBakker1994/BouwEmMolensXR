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
        canSnap = false;

        if (this.GetComponentInParent<WindmillInformation>().part == WindmillInformation.Part.BOTTOM && otherPart == WindmillInformation.Part.TOP)
        {
            canSnap = true;
           
            if (this.GetComponentInParent<WindmillInformation>().era == WindmillInformation.Era.TRADITIONAL)
            {
                AllowSnapPartTraditional();
            }

            if (this.GetComponentInParent<WindmillInformation>().era == WindmillInformation.Era.MODERN)
            {
                AllowSnapPartModern();
            }
        }

        if (this.GetComponentInParent<WindmillInformation>().part == WindmillInformation.Part.TOP && otherPart == WindmillInformation.Part.WINDMILLBLADES)
        {
            canSnap = true;

            if (this.GetComponentInParent<WindmillInformation>().era == WindmillInformation.Era.TRADITIONAL)
            {
                AllowSnapPartTraditional();
            }

            if (this.GetComponentInParent<WindmillInformation>().era == WindmillInformation.Era.MODERN)
            {
                AllowSnapPartModern();
            }
        }
    }

    public void AllowSnapPartTraditional()
    {
        if (otherEra == WindmillInformation.Era.TRADITIONAL)
        {
            if (canSnap == true)
            {
                transformToSnap.transform.position = snappingPoint.transform.position;
                transformToSnap.GetComponent<Rigidbody>().isKinematic = true;
                parentToSnap.transform.SetParent(gameObject.transform);
            }
        }
        else
        {
            canSnap = false;
        }
    }

    public void AllowSnapPartModern()
    {
        if (otherEra == WindmillInformation.Era.MODERN)
        {
            if (canSnap == true)
            {
                transformToSnap.transform.position = snappingPoint.transform.position;
                transformToSnap.GetComponent<Rigidbody>().isKinematic = true;
                parentToSnap.transform.SetParent(gameObject.transform);
            }
        }
        else
        {
            canSnap = false;
        }
    }
}
