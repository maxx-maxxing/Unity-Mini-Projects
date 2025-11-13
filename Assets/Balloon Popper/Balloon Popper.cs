using System;
using UnityEngine;

public class BalloonPopper : MonoBehaviour
{
    [SerializeField]
    private int clicksRequired = 4;
    
    [SerializeField]
    private int currentClicks = 0;

    [SerializeField]
    private float scaleIncrease = 1.1f;
    
    [SerializeField]
    private ScoreManager scoreManager; // Need to add a ScoreManager object, so you have access to that script's functions

    private void IncreaseSize()
    {
        transform.localScale *= scaleIncrease; // transform KNOWS you're referring to THIS object
    }

    private void OnMouseDown()
    {
        
        if (currentClicks < clicksRequired)
        {
            IncreaseSize();
            currentClicks++;
        }
        else
        {   
            scoreManager.IncreaseScore(1);
            Destroy(gameObject);
        }
    }
}
