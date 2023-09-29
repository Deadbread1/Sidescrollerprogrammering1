using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public enum CharacterState
{
    Grounded = 0,
    Airborne = 1,
    Jumping = 2,
    Total 
}

public class Movementcontroller : MonoBehaviour

{

    public CharacterState JumpingState = CharacterState.Airborne;
    public float MovementSpeed = 1.0f;
    public float Gravity = 1.0f;
    private float Groundlevel = 0.0f;
    public float JumpSoeedFactor = 3.0f;
    public float JumpMaxHeight = 150.0f;
    public  float JumpHeightDelta = 0.0f; 

    void Start()
    {
        
    }

   
    void Update()
    {
        bool isMoving = false;
        //Gravity 
        if(transform.position.y <= Groundlevel)
        {
            Vector3 characterposition = transform.position;
            characterposition.y = Groundlevel;
            transform.position = characterposition;
            JumpingState = CharacterState.Grounded; 
        }
        //movement
        if (Input.GetKey(KeyCode.W) && JumpingState == CharacterState.Grounded)
        {
            JumpingState = CharacterState.Jumping;
            JumpHeightDelta = 0.0f;
        }
     if(JumpingState == CharacterState.Jumping)
        {
            Vector3 Characterposition = transform.position;
            float totalJumpmovementThisFrame = MovementSpeed + JumpSoeedFactor + Time.deltaTime;
            Characterposition.y += totalJumpmovementThisFrame;
            transform.position = Characterposition;
            JumpHeightDelta += totalJumpmovementThisFrame;
            if(JumpHeightDelta >= JumpMaxHeight) 
            {
                JumpingState = CharacterState.Airborne;
                JumpHeightDelta = 0.0f;
            
            }
        }
        if (Input.GetKey(KeyCode.S)) 
        {
            Vector3 charachterposition = transform.position;
            charachterposition.y -= MovementSpeed + Time.deltaTime;
            transform.position = charachterposition;
        }
    
        if (Input.GetKey(KeyCode.A)) 
        {
            Vector3 charachterposition = transform.position;
            charachterposition.x -= MovementSpeed + Time.deltaTime;
            transform.position = charachterposition;
        }
   
        if (Input.GetKey(KeyCode.D)) 
        {
            Vector3 charachterposition = transform.position;
            charachterposition.x += MovementSpeed + Time.deltaTime;
            transform.position = charachterposition;
        }
      
        if (isMoving == false)
        {
            Vector3 Gravityposition = transform.position;
            Gravityposition.y -= Gravity + Time.deltaTime;
            if (Gravityposition.y < Groundlevel) { Gravityposition.y = Groundlevel; };
            transform.position = Gravityposition;
        }
    }
}
