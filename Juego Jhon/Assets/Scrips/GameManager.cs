using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private int appleGreenCount = 0;
    public GameObject goldKeyPrefab;
    public Vector2 keySpawnPosition;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        if (goldKeyPrefab != null)
        {
            Instantiate(goldKeyPrefab, keySpawnPosition, Quaternion.identity);
        }
    }

    public void sumValue(int value)
    {
        appleGreenCount += value;
        Debug.Log("Manzanas recolectadas: " + appleGreenCount);
    }

    public void resetValue()
    {
        appleGreenCount = 0;
    }

    public int AppleGreenCount { get => appleGreenCount; set => appleGreenCount = value; }
}


