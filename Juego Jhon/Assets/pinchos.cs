using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinchos : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            Debug.Log("¡El jugador tocó los pinchos!");

            // Puedes eliminar al jugador:
            Destroy(other.gameObject);

            // O puedes hacer algo más, como:
            // other.GetComponent<Jugador>().RecibirDaño();
        }
    }



}
