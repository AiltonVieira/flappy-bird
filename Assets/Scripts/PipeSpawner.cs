using Unity.Mathematics;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public Pipes pipe;
    public float spawnRate, minY, maxY;
    float timer;
    float counter;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnRate)
        {
            timer = 0;
            counter++;
            if (counter >= 2)
            {
                spawnRate = Mathf.Max(1.0f, spawnRate - 0.1f);
                pipe.speed = Mathf.Min(5.0f, pipe.speed + 0.2f);
                counter = 0;
            }
            Instantiate(pipe, new Vector3(transform.position.x, UnityEngine.Random.Range(minY, maxY)), quaternion.identity, this.transform);
        }
    }
}
