using UnityEngine;

public class Collision : MonoBehaviour
{

    public GameObject pipePrefab;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Pipe" || collision.gameObject.tag == "Ground")
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
            GameManager.instance.GameOver();
        }
    }
}
