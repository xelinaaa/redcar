using UnityEngine;
using UnityEngine.UI; // Jika Anda menggunakan UI untuk menampilkan skor

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score;
    public Text scoreText; // UI Text untuk menampilkan skor

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        UpdateScoreUI();
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
