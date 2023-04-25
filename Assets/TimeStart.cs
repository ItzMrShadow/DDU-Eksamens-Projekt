using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStart : MonoBehaviour, IInteractable { 

    public Timer timer;
    bool trykket;
   public void interact()
    {
        timer.TimeRun();
        trykket = true;
    }

    private void Update()
    {
        if (trykket)
        {
            timer.timeValue -= Time.deltaTime;
        }   
    }
}
