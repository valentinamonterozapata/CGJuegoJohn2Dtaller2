using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    public GameObject greenApplePrefab;
    public GameObject redApplePrefab;
    public int appleCount = 2;
    public int redAppleCount = 2;
    public List<PlatformArea> platformAreas;
    private HashSet<Vector2> usedPositions = new HashSet<Vector2>();

    void Start()
    {

        GetValidSpawnPosition();
        SpawnApples();
    }

    void SpawnApples()
    {
        int spawnedGreenApples = 0;
        int spawnedRedApples = 0;

        while (spawnedGreenApples < appleCount)
        {
            PlatformArea platformArea = platformAreas[Random.Range(0, platformAreas.Count)];
            Vector2 spawnPosition = platformArea.GetRandomPosition();

            
            if (!usedPositions.Contains(spawnPosition))
            {
                usedPositions.Add(spawnPosition);
                Instantiate(greenApplePrefab, spawnPosition, Quaternion.identity);
                Debug.Log("Manzana generada en: " + spawnPosition);
                spawnedGreenApples++;
            }
        }

        while (spawnedRedApples < redAppleCount)
        {
            PlatformArea platformArea = platformAreas[Random.Range(0, platformAreas.Count)];
            Vector2 spawnPosition = platformArea.GetRandomPosition();
            if (!usedPositions.Contains(spawnPosition))
            {
                usedPositions.Add(spawnPosition);
                Instantiate(redApplePrefab, spawnPosition, Quaternion.identity);
                Debug.Log("Manzana roja generada en: " + spawnPosition);
                spawnedRedApples++;
            }
        }
    }

    Vector2 GetValidSpawnPosition()
    {
        PlatformArea platformArea = platformAreas[Random.Range(0, platformAreas.Count)];
        Vector2 spawnPosition = platformArea.GetRandomPosition();

        if (IsPositionValid(spawnPosition))
        {
            // Ajustar la posición para que esté en el suelo
            spawnPosition.y = GetGroundedPosition(spawnPosition).y;
            return spawnPosition;
        }
        return Vector2.zero;
    }

    // Verificar si la posición es válida (evitar superposición de manzanas)
    bool IsPositionValid(Vector2 position)
    {
        foreach (Vector2 usedPosition in usedPositions)
        {
            if (Vector2.Distance(position, usedPosition) < 1.5f)  // Ajusta la distancia entre manzanas
            {
                return false;
            }
        }
        return true;
    }

    // Obtener la posición en el suelo usando un Raycast
    Vector2 GetGroundedPosition(Vector2 position)
    {
        RaycastHit2D hit = Physics2D.Raycast(position, Vector2.down, 10f);  // Lanza un rayo hacia abajo
        if (hit.collider != null)
        {
            return hit.point;  // Devuelve la posición en la que el rayo toca el suelo
        }
        return position;  // Si no se encuentra suelo, devolver la posición original
    }
}