using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public ScoreController scoreController;
    public void EndGame()
    {
        scoreController.ResetScore();
        SceneManager.LoadScene(0);
        
    }
}
