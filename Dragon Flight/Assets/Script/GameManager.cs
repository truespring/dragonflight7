using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text scoreText;

    int score = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void AddScore(int num)
    {
        score += num;
        scoreText.text = "Score: " + score;

        if (score > 1000)
        {
            SceneManager.LoadScene(1); // Load second scene
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
