using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public TextMeshProUGUI puntos; 
    public GameObject[] vidasplayer; 

    void Start()
    {
        
        if (puntos != null)
        {
            puntos.text = "0";
        }
    }

    void Update()
    {
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
            vidasplayer[indice].SetActive(false); 
        }
        else
        {
            Debug.LogWarning("Índice fuera de rango en DesactivarVida: " + indice);
        }
    }
    public void ActivarTodasVidas()
    {
        for (int i = 0; i < vidasplayer.Length; i++)
        {
            vidasplayer[i].SetActive(true);
        }
        Debug.Log("Todas las vidas han sido activadas en el HUD.");
    }







}




