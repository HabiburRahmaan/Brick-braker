using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    int Score = 0;
    public Text ScoreText;
    void Start()
    {
       
    }

   
    void Update()
    {

    }
   public void Incrementscore()
    {
        Score++;
        ScoreText.text = "score: " + Score;
    }
}