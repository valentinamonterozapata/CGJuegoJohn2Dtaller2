using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botiquin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica que el objeto que colisiona tenga la etiqueta "Player"
        if (collision.CompareTag("Player"))
        {
            // Llama al método para restaurar vidas
            Vidas.instance.RestaurarVidas();

            Debug.Log("Botiquín recolectado: Vidas restauradas.");

            // Destruye el botiquín al ser recolectado
            Destroy(gameObject);
        }
    }
}