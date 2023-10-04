using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Inimigo : MonoBehaviour
{
    public NavMeshAgent inimigo;
    public Transform Player;
    [SerializeField] private Transform spawnPoint;

    // Update is called once per frame
    void Update()
    {
        inimigo.SetDestination(Player.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player.transform.position = spawnPoint.transform.position;
            Physics.SyncTransforms();
        }

    }
}
