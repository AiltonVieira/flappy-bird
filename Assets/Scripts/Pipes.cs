using TMPro;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed, destroyX;
    public BoxCollider2D safeZone;

    public ScoreController scoreController;

    void Start()
    {
        scoreController = FindFirstObjectByType<ScoreController>();
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < destroyX)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            scoreController.UpdateScore(Mathf.RoundToInt(speed/5));
        }
    }
}
