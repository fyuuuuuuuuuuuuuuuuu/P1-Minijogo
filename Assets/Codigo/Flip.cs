using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    private bool isRotated = false;
    private Quaternion originalRotation;
    public float rotationAmount = -180.0f;
    public Transform groundChek;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool Pisando;

    void Start()
    {
        originalRotation = transform.rotation;
    }

    void Update()
    {
        Pisando = Physics.CheckSphere(groundChek.position, groundDistance, groundMask);

        if (Input.GetKeyDown(KeyCode.Space) && Pisando) 
        {
            if (isRotated)
            {             
                transform.rotation = originalRotation;
                isRotated = false;
            }
            else
            {
 
                transform.Rotate(new Vector3(0, 0, rotationAmount));
                isRotated = true;
            }
        }
    }
}