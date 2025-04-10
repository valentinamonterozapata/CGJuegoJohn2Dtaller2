using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRecolected : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))  // Verifica que la colisión sea con el jugador
        {
            if (gameObject.CompareTag("GreenApple"))  // Si la manzana es verde
            {
                GameManager.Instance.SumGreenApple(1);  // Sumar 1 manzana verde al contador
                Debug.Log("Manzana verde recolectada. Total: " + GameManager.Instance.AppleGreenCount);
            }
            else if (gameObject.CompareTag("RedApple"))  // Si la manzana es roja
            {
                GameManager.Instance.SumRedApple(1);  // Sumar 1 manzana roja al contador
                Debug.Log("Manzana roja recolectada. Total: " + GameManager.Instance.AppleRedCount);
            }

            Destroy(gameObject);
            Destroy(gameObject);// Destruir la manzana después de ser recolectada
        }
    }
}



