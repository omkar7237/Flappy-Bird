using UnityEngine;

public class MovePipe : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {
        transform.position += Vector3.left * 5f * Time.deltaTime;
    }
}
