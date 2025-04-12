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

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ShowGreenApple();
        ShowRedApple();  // Mostrar el contador de manzanas rojas
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
}