using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Movementcontroller : MonoBehaviour
{
    public float MovementSpeed = 1.0f;
    void Start()
    {
        
    }

   
    void Update()
    {
        //movement
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 charachterposition = transform.position;
            charachterposition.y += MovementSpeed + Time.deltaTime; 
            transform.position = charachterposition;
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
    }
}
