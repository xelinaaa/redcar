using UnityEngine;
using UnityEngine.UI; // Jika Anda menggunakan UI untuk menampilkan pesan
using UnityEngine.SceneManagement; // Jika ingin mengubah scene

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int winScore = 10; // Skor yang diperlukan untuk menang

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

    private void Update()
    {
        if (ScoreManager.instance != null && ScoreManager.instance.score >= winScore)
        {
            WinGame();
        }
    }

    public void WinGame()
    {
        UIManager.instance.ShowWinUI();
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
        ScoreManager.instance.score = 0;
        Time.timeScale = 1;
        UIManager.instance.HideWinUI();
    }
}
