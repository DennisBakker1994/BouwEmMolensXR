using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultMovement : MonoBehaviour
{
    private Movement controls;
    private Vector2 move;
    public CharacterController character;
    public float moveSpeed = 1f; 



    void Start()
    {
        controls = new Movement();
    }

    public void PlayerMovement()
    {
        //move = controls.Player.ZXMovement.ReadValue<Vector2>();
        Vector3 movement = (move.y * transform.forward) + (move.x * transform.right);
        character.Move(movement * moveSpeed * Time.deltaTime);

    }
    void Update()
    {
        
    }
}
