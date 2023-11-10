using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPickups : MonoBehaviour
{
  

    
        public float rotationSpeed = 90f; // Adjust the speed as per your preference

        // Update is called once per frame
        void Update()
        {
            // Rotate the pickup around the Z-axis
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
    }




