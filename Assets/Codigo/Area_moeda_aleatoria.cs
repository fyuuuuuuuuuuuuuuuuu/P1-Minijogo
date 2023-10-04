using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area_moeda_aleatoria : MonoBehaviour
{
    public GameObject moedaPrefab;
    public BoxCollider spawnArea; // Referência ao BoxCollider onde as moedas devem aparecer

    public void SpawnMoeda()
    {
        if (moedaPrefab != null && spawnArea != null)
        {
            Vector3 spawnPosition = GetRandomSpawnPosition();
            Instantiate(moedaPrefab, spawnPosition, Quaternion.identity);
        }
    }

    private Vector3 GetRandomSpawnPosition()
    {
        Vector3 center = spawnArea.bounds.center;
        Vector3 extents = spawnArea.bounds.extents;

        float randomX = Random.Range(center.x - extents.x, center.x + extents.x);
        float randomY = Random.Range(center.y - extents.y, center.y + extents.y);
        float randomZ = Random.Range(center.z - extents.z, center.z + extents.z);

        return new Vector3(randomX, randomY, randomZ);
    }

}
