using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAnimation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float takeoffRotation, langingRotation;

    private float rotationZ;

    public void ApplyRotation(float velosityY)
    {
        if (rotationZ > langingRotation)
        {
            float offset = 1f;
            if (velosityY > 0.5)
            {
                offset = velosityY;
            }
            
            offset = Mathf.Abs(offset);

            rotationZ -= rotationSpeed * Time.deltaTime / offset;
            transform.localEulerAngles = new Vector3(0, 0, rotationZ);
        }
    }

    public void StartRotation()
    {
        rotationZ = takeoffRotation;
    }
}
