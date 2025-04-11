using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRecolected : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (gameObject.CompareTag("Star 1") || gameObject.CompareTag("Star 2") || gameObject.CompareTag("Star 3"))
            {
                GameManager.Instance.SumStar(1);  // Sumar 1 estrella al contador
                Debug.Log("Estrella recolectada. Total: " + GameManager.Instance.StarCount);
            }
            else if (gameObject.CompareTag("GreenApple"))
            {
                GameManager.Instance.SumGreenApple(1);
                Debug.Log("Manzana verde recolectada. Total: " + GameManager.Instance.AppleGreenCount);
            }
            else if (gameObject.CompareTag("RedApple"))
            {
                GameManager.Instance.SumRedApple(1);
                Debug.Log("Manzana roja recolectada. Total: " + GameManager.Instance.AppleRedCount);
            }

            // Destruir el objeto después de haber sido recolectado
            Destroy(gameObject);  // Destruir la estrella (o cualquier objeto que se recoja)
        }
    }
}




