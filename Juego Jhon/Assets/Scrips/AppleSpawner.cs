using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    public GameObject greenApplePrefab;
    public int appleCount = 5;
    public List<PlatformArea> platformAreas;
    private HashSet<Vector2> usedPositions = new HashSet<Vector2>();

    void Start()
    {
        SpawnApples();
    }

    void SpawnApples()
    {
        int spawnedApples = 0;
        while (spawnedApples < appleCount)
        {
            PlatformArea platformArea = platformAreas[Random.Range(0, platformAreas.Count)];
            Vector2 spawnPosition = platformArea.GetRandomPosition();

            
            if (!usedPositions.Contains(spawnPosition))
            {
                usedPositions.Add(spawnPosition);
                Instantiate(greenApplePrefab, spawnPosition, Quaternion.identity);
                Debug.Log("Manzana generada en: " + spawnPosition);
                spawnedApples++;
            }
        }
    }
}