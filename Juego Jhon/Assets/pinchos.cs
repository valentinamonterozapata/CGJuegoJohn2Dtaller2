using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinchos : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            Debug.Log("�El jugador toc� los pinchos!");

            // Puedes eliminar al jugador:
            Destroy(other.gameObject);

            // O puedes hacer algo m�s, como:
            // other.GetComponent<Jugador>().RecibirDa�o();
        }
    }



}
