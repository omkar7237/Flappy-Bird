using UnityEngine;

public class LoopGround : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float resetX = -6f;
    [SerializeField] private float startX = 6f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x <= resetX)
        {
            transform.position = new Vector3(startX, transform.position.y, transform.position.z);
        }
    }
}
