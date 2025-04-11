using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dañomurcielago : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            Debug.Log("¡El jugador tocó los murcielagos!");

            // Puedes eliminar al jugador:
            Destroy(other.gameObject);
            
            
            //other.GetComponent<Vidas>().PerderVida();
            
        }
    }
}
