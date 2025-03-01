using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb_spawner : MonoBehaviour
{
    public GameObject fallingObjectPrefab; // Assign your Falling Object Prefab here
    public float spawnInterval = 1.5f; // Time between spawns
    public float spawnXMin = -8f; // Minimum X position
    public float spawnXMax = 8f; // Maximum X position
    public float spawnY = 6f; // Spawn height (above screen)

    void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    IEnumerator SpawnObjects()
    {
        while (true) // Infinite loop to keep spawning
        {
            SpawnFallingObject();
            yield return new WaitForSeconds(spawnInterval);
        }
    }
    void SpawnFallingObject()
    {
        float randomX = Random.Range(spawnXMin, spawnXMax); // Random X position
        Vector2 spawnPosition = new Vector2(randomX, spawnY); // Spawn above screen
        Instantiate(fallingObjectPrefab, spawnPosition, Quaternion.identity);
    }
}
