using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    int score, highScore;
    public UIController uiController;

    public void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore");
        uiController.UpdateHighScore(highScore);
    } 
    public void UpdateScore(int amount)
    {
        score += amount;
        if (score > highScore)
        {
            UpdateHighScore();
        }
        uiController.UpdateScore(score);
    }

    public void ResetScore()
    {
        score = 0;
        uiController.UpdateScore(score);
    }

    public void UpdateHighScore()
    {
        highScore = score;
        PlayerPrefs.SetInt("highScore", highScore);
        uiController.UpdateHighScore(highScore);
    }
}
