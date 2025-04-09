using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public TextMeshProUGUI puntos; // Texto para mostrar los puntos
    public GameObject[] vidasplayer; // Array de GameObjects que representan las vidas del jugador

    void Start()
    {
        // Inicializar los puntos en 0 al inicio del juego
        if (puntos != null)
        {
            puntos.text = "0";
        }
    }

    void Update()
    {
        // Verificar que Vidas.instance no sea null antes de acceder a sus propiedades
        if (Vidas.instance != null)
        {
            puntos.text = Vidas.instance.PuntosTotales.ToString();
        }
    }

    public void ActualizarPuntos(int PuntosTotales)
    {
        if (puntos != null)
        {
            puntos.text = PuntosTotales.ToString();
        }
    }

    public void DesactivarVida(int indice)
    {
        if (indice >= 0 && indice < vidasplayer.Length)
        {
            Debug.Log("Desactivando vida en índice: " + indice);
            vidasplayer[indice].SetActive(false); // Oculta la vida correspondiente
        }
        else
        {
            Debug.LogWarning("Índice fuera de rango en DesactivarVida: " + indice);
        }
    }

}




