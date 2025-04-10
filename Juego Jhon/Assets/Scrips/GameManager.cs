using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;  // Instancia estática

    public int AppleGreenCount = 0;
    public int AppleRedCount = 0;

    public TMPro.TextMeshProUGUI txtGreenApple;
    public TMPro.TextMeshProUGUI txtRedApple;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;  // Asignar la instancia
            DontDestroyOnLoad(gameObject);  // No destruir el GameManager entre escenas
            Debug.Log("GameManager persistente entre escenas.");
        }
    } 

    public void SumGreenApple(int value)
    {
        AppleGreenCount += value;
    }

    public void SumRedApple(int value)
    {
        AppleRedCount += value * 2;  // 2 puntos por cada manzana roja
    }
} // <-- Se cerró correctamente la clase GameManager



