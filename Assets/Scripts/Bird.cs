using UnityEngine;

public class Bird : MonoBehaviour
{
    public float jumpForce;
    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        rb.rotation += rb.linearVelocityY * 0.02f;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocityX, 0.0f);
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
