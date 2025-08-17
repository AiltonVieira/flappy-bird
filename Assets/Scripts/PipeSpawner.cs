using Unity.Mathematics;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate, minY, maxY;
    float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnRate)
        {
            timer = 0;
            Instantiate(pipe, new Vector3(transform.position.x, UnityEngine.Random.Range(minY, maxY)), quaternion.identity);
        }
    }
}
