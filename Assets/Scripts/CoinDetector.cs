using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDetector : MonoBehaviour
{
    public int scoreValue = 1; // Nilai skor yang akan ditambahkan

    private void OnTriggerEnter(Collider other)
    {
        // Cek apakah objek yang bersentuhan adalah player
        if (other.CompareTag("Player"))
        {
            // Tambahkan skor
            ScoreManager.instance.AddScore(scoreValue);

            // Hapus koin dari scene
            Destroy(gameObject);
        }
    }
    
}
