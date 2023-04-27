using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public float timeValue = 90;
    public TMP_Text timeText;
    public TMP_Text timeText2;
    // Update is called once per frame
    void Update()
    {
       
        //TimeRun();
        DisplayTime(timeValue);
        SceneSkift();
    }
    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliseconds = (timeToDisplay % 1) * 1000;
        timeText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
        timeText2.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
       
    }

    public void TimeRun()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }
    }
    void SceneSkift()
    {
        if (timeValue <= 0)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
}
