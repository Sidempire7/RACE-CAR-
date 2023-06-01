using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPerson : MonoBehaviour
{
    
    public Transform target; // The target object (e.g., the car)
    public Vector3 offset = new Vector3(0f, 2f, -5f); // Camera offset from the target

    private void FixedUpdate()
    {
        // Calculate the desired position of the camera based on the target's position and the offset
        Vector3 desiredPosition = target.position - target.forward * offset.z + target.up * offset.y;

        // Set the camera position to the desired position
        transform.position = desiredPosition;

        // Make the camera look at the target
        transform.LookAt(target);
    }
    
}
