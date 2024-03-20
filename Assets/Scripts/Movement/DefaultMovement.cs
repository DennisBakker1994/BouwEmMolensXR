using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultMovement : MonoBehaviour
{
    public CharacterController player;



    public void Up()
    {
        transform.position = new Vector3 (0, 0.5f, 0); 
    }


}
