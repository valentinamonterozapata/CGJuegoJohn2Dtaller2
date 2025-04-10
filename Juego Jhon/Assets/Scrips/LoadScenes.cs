using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    public GameObject PanelCreditos; 
    public GameObject PanelMenu; 
    public GameObject PanelScores; 

    // Start is called before the first frame update
    void Start()
    {
        if (PanelCreditos != null)
        {
            PanelCreditos.SetActive(false); 
        }

        if (PanelMenu != null)
        {
            PanelMenu.SetActive(true); 
        }

        if (PanelScores != null)
        {
            PanelScores.SetActive(false); 
        }
    }

    public void Creditos()
    {
        if (PanelCreditos != null && PanelMenu != null)
        {
            PanelCreditos.SetActive(true); 
            PanelMenu.SetActive(false);
        }
        else
        {
            Debug.LogWarning("PanelCreditos o PanelMenu no están asignados en el Inspector.");
        }
    }

    public void Atras()
    {
        if (PanelCreditos != null && PanelMenu != null)
        {
            PanelCreditos.SetActive(false); 
            PanelMenu.SetActive(true); 
        }

        if (PanelScores != null)
        {
            PanelScores.SetActive(false); 
            PanelMenu.SetActive(true); 
        }
    }

    public void Score()
    {
        if (PanelScores != null && PanelMenu != null)
        {
            PanelScores.SetActive(true); 
            PanelMenu.SetActive(false); 
        }
        else
        {
            Debug.LogWarning("PanelScores o PanelMenu no están asignados en el Inspector.");
        }
    }

    public void LoadScene1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ComoJugar1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void VolMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void QuitarSonido()
    {
        bool isMuted = AudioListener.volume == 0;
        AudioListener.volume = isMuted ? 1 : 0;
        Debug.Log("Quitar Sonido");
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Salir");
    }
}




