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

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
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
}




