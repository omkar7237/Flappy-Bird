using UnityEngine;

public class SpaceBarStart : MonoBehaviour
{
    private ChangeScene changeScene;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            changeScene = ChangeScene.instance;
            changeScene.Scene();
        }
    }
}
