using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{   
    public static ChangeScene instance;
    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    public void Scene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex + 1);
    }
}
