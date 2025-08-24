using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Button pauseButton, resumeButton, mainMenuButton, playButton, exitGameButton;
    public TMP_Text txtScore;
    public TMP_Text txtHighScore;
    public GameObject pauseMenu, mainMenu;

    void Start()
    {
        pauseButton.onClick.AddListener(PauseGame);
        resumeButton.onClick.AddListener(ResumeGame);
        mainMenuButton.onClick.AddListener(ShowMainMenu);
        playButton.onClick.AddListener(StartGame);
        exitGameButton.onClick.AddListener(ExitGame);
        resumeButton.gameObject.SetActive(false);
        pauseButton.gameObject.SetActive(false);
        pauseMenu.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
        txtScore.gameObject.SetActive(false);
        Time.timeScale = 0;
    }

    public void ShowMainMenu()
    {
        mainMenu.gameObject.SetActive(true);
        pauseMenu.gameObject.SetActive(false);
        txtScore.gameObject.SetActive(false);
        pauseButton.gameObject.SetActive(false);
        Time.timeScale = 0;
    }

    public void StartGame()
    {
        mainMenu.gameObject.SetActive(false);
        pauseButton.gameObject.SetActive(true);
        txtScore.gameObject.SetActive(true);
        Time.timeScale = 1;
    }

    public void PauseGame()
    {
        pauseButton.gameObject.SetActive(false);
        resumeButton.gameObject.SetActive(true);
        pauseMenu.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        pauseButton.gameObject.SetActive(true);
        resumeButton.gameObject.SetActive(false);
        pauseMenu.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void ExitGame()
    {
        Application.Quit();
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
