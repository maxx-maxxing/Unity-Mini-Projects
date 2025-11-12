using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score;

    public void IncreaseScore(int amount)
    {
        score += amount;
    }
}
