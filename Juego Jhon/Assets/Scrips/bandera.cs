using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bandera : MonoBehaviour
{
    public GameObject panel; // Asigna el panel desde el Inspector

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("final de jeugol...");
            panel.SetActive(true); // Activa el panel
            gameObject.SetActive(false);
        }
    }
}