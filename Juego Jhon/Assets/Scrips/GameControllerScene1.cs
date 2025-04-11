using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameControllerScene1 : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI txtGreenApple;  // Para las manzanas verdes
    [SerializeField]
    private TextMeshProUGUI txtRedApple;    // Para las manzanas rojas
    [SerializeField]
    private TextMeshProUGUI txtStar;  // Para las estrellas

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        ShowGreenApple();
        ShowRedApple();
        ShowStar();
    }

    // Mostrar el contador de manzanas verdes
    public void ShowGreenApple()
    {
        txtGreenApple.text = GameManager.Instance.AppleGreenCount.ToString();
    }

    // Mostrar el contador de manzanas rojas
    public void ShowRedApple()
    {
        txtRedApple.text = GameManager.Instance.AppleRedCount.ToString();

    }
    public void ShowStar()
    {
        txtStar.text = GameManager.Instance.StarCount.ToString();  // Mostrar el contador de estrellas
    }

}   