using UnityEngine;

public class SpaceBarReset : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameManager.instance;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver)
        {
            gameManager.Restart();
        }
    }
}
