using UnityEngine;
using UnityEngine.SceneManagement; // Untuk mengelola scene

public class RestartButton : MonoBehaviour
{
    public void RestartGame()
    {
        // Memuat ulang scene saat ini
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ScoreManager.instance.score = 0;
        Time.timeScale = 1;
    }
}
