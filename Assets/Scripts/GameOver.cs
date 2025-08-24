using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameController gameController;

    void Start()
    {
        gameController = FindFirstObjectByType<GameController>();
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameController.EndGame();
        }
    }
}
