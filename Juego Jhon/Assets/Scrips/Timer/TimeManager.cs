using UnityEngine;

public static class TimeManager
{
    public static float totalTimeScene2 = 0f; // Tiempo acumulado en la escena 2
    public static float totalTimeScene3 = 0f; // Tiempo acumulado en la escena 3

    public static void ResetTimes()
    {
        totalTimeScene2 = 0f;
        totalTimeScene3 = 0f;
    }
}

