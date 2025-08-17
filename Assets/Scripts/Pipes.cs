using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed, destroyX;
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < destroyX)
        {
            Destroy(gameObject);
        }
    }
}
