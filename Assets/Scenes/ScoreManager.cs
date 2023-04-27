using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text highscoreText;

    int score = 0;
    int highscore = 0;
    public static ScoreManager Instance;
    
    void Start()
    {
        Instance = this;
        score = 0;
        AddScore(0);

      
        highscoreText.text = PlayerPrefs.GetInt("Highscore", 0).ToString();

        
    }


    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "POINTS: " + score.ToString();
       


            if (score >= PlayerPrefs.GetInt("Highscore", 0))
            {

                highscore = score;
                 
                PlayerPrefs.SetInt("Highscore", highscore);
                //highscore = score;
               
                highscoreText.text = "HIGHSCORE: " + highscore.ToString();
                
            }
      

        

    }

   



}
