using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vidas : MonoBehaviour
{
    public static Vidas instance { get; private set; }
    public HUD hud;

    public int PuntosTotales { get; private set; } // Propiedad pública para los puntos totales

    private int vidasTotales = 5;

    [SerializeField] public float limiteCaidaY; // Altura mínima antes de reaparecer

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }

    void Update()
    {
        // Verifica si la posición en Y del objeto es menor que el límite
        if (transform.position.y < limiteCaidaY)
        {
            PerderVida(); // Llama al método para perder una vida
        }
    }

    public void SumarPuntos(int puntosASumar)
    {
        PuntosTotales += puntosASumar;
        hud.ActualizarPuntos(PuntosTotales);
    }

    public void PerderVida()
    {
        Debug.Log("PerderVida llamado. Vidas restantes: " + vidasTotales);

        if (vidasTotales > 0)
        {
            vidasTotales--;
            hud.DesactivarVida(vidasTotales); // Actualiza el HUD para desactivar una vida
        }

        if (vidasTotales == 0)
        {
            Debug.Log("Game Over");
            // Reiniciar la escena actual
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void RestaurarVidas()
    {
        // Supongamos que 5 es la cantidad máxima de vidas.
        vidasTotales = 5;

        // Actualiza el HUD para activar todas las vidas.
        hud.ActivarTodasVidas();

        Debug.Log("Vidas restauradas a: " + vidasTotales);
    }




}