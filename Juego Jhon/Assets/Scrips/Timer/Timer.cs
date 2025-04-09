using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    #region sonidos
    [SerializeField]
    private AudioClip stop;
    [SerializeField]
    private AudioSource respuestaAudio;
    #endregion

    public TextMeshProUGUI timerMinutes;
    public TextMeshProUGUI timerSeconds;
    public TextMeshProUGUI timerSeconds100;

    private float startTime;
    private float stopTime;
    private float timerTime;
    private bool isRunning = false;

    [SerializeField]
    private int sceneNumber; 

    void Start()
    {
        TimerReset();
        TimerStart();
    }

    public void TimerStart()
    {
        if (!isRunning)
        {
            isRunning = true;
            startTime = Time.time;
        }
    }

    public void TimerStop()
    {
        if (isRunning)
        {
            isRunning = false;
            stopTime = timerTime;

            
            if (sceneNumber == 2)
            {
                TimeManager.totalTimeScene2 = stopTime;
            }
            else if (sceneNumber == 3)
            {
                TimeManager.totalTimeScene3 = stopTime;
            }

            if (stopTime >= 30)
            {
                respuestaAudio.clip = stop;
                respuestaAudio.Play();
            }
        }
    }

    public void TimerReset()
    {
        stopTime = 0;
        isRunning = false;
        timerMinutes.text = timerSeconds.text = timerSeconds100.text = "00";
    }

    void Update()
    {
        if (isRunning)
        {
            timerTime = stopTime + (Time.time - startTime);
            int minutesInt = (int)timerTime / 60;
            int secondsInt = (int)timerTime % 60;
            int seconds100Int = (int)(Mathf.Floor((timerTime - (secondsInt + minutesInt * 60)) * 100));

            timerMinutes.text = (minutesInt < 10) ? "0" + minutesInt : minutesInt.ToString();
            timerSeconds.text = (secondsInt < 10) ? "0" + secondsInt : secondsInt.ToString();
            timerSeconds100.text = (seconds100Int < 10) ? "0" + seconds100Int : seconds100Int.ToString();
        }
    }
}

