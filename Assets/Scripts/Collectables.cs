using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectables : MonoBehaviour
{
    public int Candy;
    public Collectables(string name, int scoreValue, int restoreValue)
    {
        
        this.Candy = scoreValue;
        
    }
    public void UpdateScore()
    {
        CandyController.scoreController.UpdateScore(Candy);
    }
}
