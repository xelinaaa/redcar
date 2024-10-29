using UnityEngine;
using UnityEngine.UI; // Jika Anda menggunakan UI untuk menampilkan pesan
using UnityEngine.SceneManagement; // Jika ingin mengubah scene

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int winScore = 10; // Skor yang diperlukan untuk menang
    public Text winText; // UI Text untuk menampilkan pesan kemenangan
    public GameObject buttonRestart; // Referensi ke objek player

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

        winText.gameObject.SetActive(false); // Sembunyikan pesan kemenangan di awal
        buttonRestart.SetActive(false); 
    }

    private void Update()
    {
        // Cek apakah skor pemain mencapai winScore
        if (ScoreManager.instance.score >= winScore)
        {
            WinGame();
        }
    }

    public void WinGame()
    {
        winText.gameObject.SetActive(true); // Tampilkan pesan kemenangan
        buttonRestart.SetActive(true); // Tampilkan pesan kemenangan
        winText.text = "You Win!";
        Time.timeScale = 0; // Hentikan permainan (jika diperlukan)
        // Tambahkan logika lain yang ingin Anda lakukan saat menang, seperti memuat scene baru
    }
}
