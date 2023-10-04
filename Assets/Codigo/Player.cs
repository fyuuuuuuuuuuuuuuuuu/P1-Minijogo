using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;

    public float velocidade = 12f;
    public float gravidade = -9.81f;
    public float altura_Pulo = 3f;

    public Transform groundChek;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool Pisando;

    // Update is called once per frame
    void Update()
    {
        Pisando = Physics.CheckSphere(groundChek.position, groundDistance, groundMask);

        if (Pisando && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * velocidade * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && Pisando)
        {
            velocity.y = Mathf.Sqrt(altura_Pulo * -2f * gravidade);
        }

        velocity.y += gravidade * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
