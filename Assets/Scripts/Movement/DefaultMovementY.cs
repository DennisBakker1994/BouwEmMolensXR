using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;

public class DefaultMovementY : MonoBehaviour
{
    private Movement controls;
    private float move = 0;
    public CharacterController character;
    public float moveSpeed;

    public void Start()
    {
        controls = new Movement();
    }

    public void PlayerUpDown()
    {
        move = controls.Player.YMovement.ReadValue<float>();
    }

    public void Update()
    {
        
    }








}
//private Movement controls;
//private Vector2 move;
//public CharacterController character;
//public float moveSpeed = 1f;



//void Start()
//{
 //   controls = new Movement();
//}

//public void PlayerMovement()
//{
 //   move = controls.Player.ZXMovement.ReadValue<Vector2>();
 //   Vector3 movement = (move.y * transform.up) + (move.x * transform.right);
 //   character.Move(movement * moveSpeed * Time.deltaTime);

//}