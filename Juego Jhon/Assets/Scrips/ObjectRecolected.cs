using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRecolected : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.sumValue(1); // Sumar 1 manzana al contador
            Debug.Log("Manzana recolectada. Total: " + GameManager.Instance.AppleGreenCount);
            Destroy(gameObject);
        }
    }
}


