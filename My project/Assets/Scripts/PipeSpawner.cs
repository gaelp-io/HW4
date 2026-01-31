using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;     // The prefab of PipePair
    public float spawnRate = 2f;      // Seconds between pipes
    public float minY = -1f;          // Minimum Y position
    public float maxY = 3f;           // Maximum Y position
    public float spawnX = 10f;        // X position to spawn pipes

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    void SpawnPipe()
    {
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(spawnX, randomY, 0f);

        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
    }
}
