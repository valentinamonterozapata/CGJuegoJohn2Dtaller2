using UnityEngine;
using TMPro;

public class EndSceneManager : MonoBehaviour
{
    public TextMeshProUGUI totalTimeText; // Texto para mostrar el tiempo total

    void Start()
    {
        ShowTotalTime();
    }

    void ShowTotalTime()
    {
        float totalTime = TimeManager.totalTimeScene2 + TimeManager.totalTimeScene3;

        int minutesInt = (int)totalTime / 60;
        int secondsInt = (int)totalTime % 60;
        int seconds100Int = (int)(Mathf.Floor((totalTime - (secondsInt + minutesInt * 60)) * 100));

        totalTimeText.text = string.Format("Tiempo Total: {0:00}:{1:00}:{2:00}", minutesInt, secondsInt, seconds100Int);
    }
}

