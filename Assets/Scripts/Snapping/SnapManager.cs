using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SnapManager : MonoBehaviour
{
    [Header("Variable")]
    public bool canSnap;
    public bool canBuildMode;
    public GameObject snappingPoint;
    public Transform partToSnap;
    public GameObject previousSnapManager;

    public WindmillInformation.Part otherPart;
    public WindmillInformation.Era otherEra;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Windmill")
        {
            otherPart = other.gameObject.GetComponentInParent<WindmillInformation>().part;
            otherEra = other.gameObject.GetComponentInParent<WindmillInformation>().era;
            partToSnap = other.gameObject.transform;
            partToSnap.GetComponentInChildren<SnapManager>().previousSnapManager = this.gameObject;
        }
    }

    public void SetPreviousSnapManager()
    {
        if (previousSnapManager != null)
        {
            previousSnapManager.GetComponent<SnapManager>().CheckIfCanSnap();
        }
    }

    public void CheckIfCanSnap()
    {
        canSnap = false;


        if (this.GetComponentInParent<WindmillInformation>().part == WindmillInformation.Part.BOTTOM && otherPart == WindmillInformation.Part.TOP)
        {
            canSnap = true;
            
            AllowSnapPart();
        }

        if (this.GetComponentInParent<WindmillInformation>().part == WindmillInformation.Part.TOP && otherPart == WindmillInformation.Part.WINDMILLBLADES)
        {
            canSnap = true;
            
            AllowSnapPart();

        }
    }

    public void AllowSnapPart()
    {

        if (canSnap == true)
        {
            partToSnap.transform.position = snappingPoint.transform.position;
            partToSnap.GetComponent<Rigidbody>().isKinematic = true;

            if (previousSnapManager != null)
            {
                partToSnap.SetParent(previousSnapManager.transform);
            }

            snappingPoint.GetComponent<SphereCollider>().enabled = false;

            if (partToSnap.GetComponent<WindmillInformation>().part != WindmillInformation.Part.WINDMILLBLADES)
            {
                partToSnap.GetComponentInChildren<SnapManager>().snappingPoint.GetComponent<SphereCollider>().enabled = true;
            }
            else
            {
                canBuildMode = true;
            }
        }
        else
        {
            canSnap = false;
        }


        //if (otherEra == WindmillInformation.Era.TRADITIONAL)
        //{
        //    if (canSnap == true)
        //    {
        //        partToSnap.transform.position = snappingPoint.transform.position;
        //        partToSnap.GetComponent<Rigidbody>().isKinematic = true;
        //        if (previousSnapManager != null)
        //        {
        //            partToSnap.SetParent(previousSnapManager.transform);
        //        }
        //        snappingPoint.GetComponent<SphereCollider>().enabled = false;

        //        if (partToSnap.GetComponent<WindmillInformation>().part != WindmillInformation.Part.WINDMILLBLADES)
        //        {
        //            partToSnap.GetComponentInChildren<SnapManager>().snappingPoint.GetComponent<SphereCollider>().enabled = true;
        //        }
        //        else
        //        {
        //            canBuildMode = true;
        //        }
        //    }
        //    else
        //    {
        //        canSnap = false;
        //    }
        //}
        //else
        //{
        //    canSnap = false;
        //}
    }
}
