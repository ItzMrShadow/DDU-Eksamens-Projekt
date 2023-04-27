using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TimeStop : MonoBehaviour
{
    public GameObject stop;
    public PlayerMovement movement;
    private void OnTriggerEnter(Collider other)
    {
        stop.SetActive(false);
        movement.gameObject.transform.position = stop.transform.position;
    }

   
}