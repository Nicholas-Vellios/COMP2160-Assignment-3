using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text timerText;
    private Time time;
    private float minutes;
    private float seconds;
    private float hundredths;

    void Update()
    {
        minutes = (int) Time.time / 60;
        seconds = (int) Time.time;
        hundredths = (int) Time.time / 100;
        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, hundredths);
    }
}
