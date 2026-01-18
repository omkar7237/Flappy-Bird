using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Score : MonoBehaviour
{
    private ScoreManager scoreManager;
    public static Score instance;

    [SerializeField] private TextMeshProUGUI currentScoreText;
    [SerializeField] private TextMeshProUGUI bestScoreText;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = FindAnyObjectByType<ScoreManager>();
        currentScoreText.text = scoreManager.score.ToString();
        bestScoreText.text = PlayerPrefs.GetInt("Highscore",0).ToString();
    }

    // Update is called once per frame
    void UpdateHighScore()
    {
        int highscore = PlayerPrefs.GetInt("Highscore",0);

        if(scoreManager.score > PlayerPrefs.GetInt("Highscore",0))
        {
            PlayerPrefs.SetInt("Highscore", scoreManager.score);
            bestScoreText.text = scoreManager.score.ToString();
            
        }
    }

    void UpdateScore()
    {
        scoreManager.score++;
        currentScoreText.text = scoreManager.score.ToString();
        UpdateHighScore();
    }

    void OnTriggerEnter2D(Collider2D collision)
        {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Score!");
            Destroy (gameObject);
            instance.UpdateScore();
        }
    }

}
