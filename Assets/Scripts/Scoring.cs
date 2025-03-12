
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Scoring : MonoBehaviour
{
    public TMP_Text ScoreText;
    public static 
    
    int score = 0;
    public int maxScore;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void AddScore(int newScore)
    {
        score += newScore;
    }

    public void UpdateScore()
    {
        ScoreText.SetText("Score 0" + score);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
