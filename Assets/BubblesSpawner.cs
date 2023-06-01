using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblesSpawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public int numberOfInstances = 10;
    public float spawnRadius = 10f;

    private void Start()
    {
        for (int i = 0; i < numberOfInstances; i++)
        {
            Vector3 spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
            spawnPosition.z = 0;
            Instantiate(objectPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
