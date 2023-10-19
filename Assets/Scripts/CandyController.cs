using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CandyController : MonoBehaviour
{
    public static CandyController scoreController;

    public TextMeshProUGUI scoreUI;

    private int totalScore;

    private void Awake()
    {
        if (scoreController == null)
        {
            scoreController = this;
        }
        scoreUI.text = "Candy: 0";
    }

    public void UpdateScore(int score)
    {
        totalScore += score;

        scoreUI.text = "Candy: " + totalScore.ToString();
    }
}
