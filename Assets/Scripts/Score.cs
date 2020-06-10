using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] int currentScore = 0, pointPerBlock = 83;
    [SerializeField] TextMeshProUGUI scoreText;

    private void Start()
    {
        scoreText.text = currentScore.ToString();
    }
    

    public void increaseScore()
    {
        currentScore += pointPerBlock;
        scoreText.text = currentScore.ToString();
    }
   
}
