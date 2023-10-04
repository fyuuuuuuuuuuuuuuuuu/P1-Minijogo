using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Moeda : MonoBehaviour
{
    public int value;

    void Update()
    {
        transform.Rotate(0f, 50f * Time.deltaTime, 0f, Space.Self);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Moeda_Text.instance.Aumenta_Valor(value);

            // Encontre o MoedaSpawner na cena e chame a função SpawnMoeda
            Area_moeda_aleatoria moedaSpawner = FindObjectOfType<Area_moeda_aleatoria>();
            if (moedaSpawner != null)
            {
                moedaSpawner.SpawnMoeda();
            }
        }
    }
}