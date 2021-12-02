using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
   public void StopTimeWithDelay(float delay)
    {
        Invoke("StopTime", delay);
    }

    private void StopTime()
    {
        Time.timeScale = 0;
    }
}
