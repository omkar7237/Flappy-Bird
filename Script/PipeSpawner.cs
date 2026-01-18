using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float timetaken = 1.5f;
    public float heightOffset = 0.5f;
    public GameObject pipePrefab;
    private float timer = 0;
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > timetaken)
        {
            timetaken = timetaken - 0.001f;
            SpawnPipe();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    void SpawnPipe()
    {
        Vector2 spawnPosition = transform.position + new Vector3(0,Random.Range(-heightOffset,heightOffset));
        GameObject pipe = Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
        Destroy(pipe, 10f);
    }
}
