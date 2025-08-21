using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Button pauseButton, resumeButton;
    public TMP_Text txtScore;
    public TMP_Text txtHighScore;

    void Start()
    {
        pauseButton.onClick.AddListener(PauseGame);
        resumeButton.onClick.AddListener(ResumeGame);
        resumeButton.gameObject.SetActive(false);
    }

    public void PauseGame()
    {
        pauseButton.gameObject.SetActive(false);
        resumeButton.gameObject.SetActive(true);
    }

    public void ResumeGame()
    {
        pauseButton.gameObject.SetActive(true);
        resumeButton.gameObject.SetActive(false);
    }

    public void UpdateScore(int score)
    {
        txtScore.text = score.ToString();
    }

    public void UpdateHighScore(int highScore)
    {
        txtHighScore.text = $"HighScore: {highScore}";
    }
}
