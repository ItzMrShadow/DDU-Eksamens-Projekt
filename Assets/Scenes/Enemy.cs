using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Stats")]
    public int health;
    public int point = 1;
    public void TakeDamage(int damage)
    {
        health -= damage;
        ScoreManager.Instance.AddScore(point);
        if (health <= 0)
            Destroy(gameObject);
    }
}
