using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    [SerializeField]
    private TMP_Text scoreText; //TMP_Text is a method of TMPro that lets you set the text of UI (TMP UI Object in Unity)

    void Start()
    {
        UpdateScore();
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScore();
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
}
