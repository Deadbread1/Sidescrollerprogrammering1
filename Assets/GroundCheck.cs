using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{

    public PhysicsCharacterController PhysicsCharacterController = null;
    private void OnCollisionEnter2E (Collision2D collision)
    {
        PhysicsCharacterController.JumpingState = CharacterState.Grounded;
    }
}
