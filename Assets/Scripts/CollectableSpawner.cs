using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSpawner : MonoBehaviour
{
    public GameObject collectable;
    public float spawnAreaSize;

    public float spawnDelay;
    public float spawnTimer;

    private void Start()
    {
        InvokeRepeating("SpawnCollectable", spawnDelay, spawnTimer);
    }

    public void SpawnCollectable()
    {
        float randomX = Random.Range(-spawnAreaSize / 2, spawnAreaSize / 2);
        float randomZ = Random.Range(-spawnAreaSize / 2, spawnAreaSize / 2);

        Vector3 spawnPosition = new Vector3(randomX, transform.position.y, randomZ);
        Debug.Log(spawnPosition);

        GameObject collectableInstance = Instantiate(collectable, transform);
        collectableInstance.transform.position = spawnPosition;
    }
}
