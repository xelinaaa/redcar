using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public Text winText;
    public GameObject WinUI;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Agar UIManager tidak terhapus saat scene reload
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        Debug.Log("UIManager Initialized");
        FindReferences(); // Cari referensi awal
        HideWinUI();
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        FindReferences();
        HideWinUI();
    }

    private void FindReferences()
    {
        if (winText == null)
        {
            winText = GameObject.Find("YouWinText")?.GetComponent<Text>();
            if (winText != null);
            else Debug.LogWarning("winText not found.");
        }

        if (WinUI == null)
        {
            WinUI = GameObject.Find("WinLoseUI");
            if (WinUI != null);
            else Debug.LogWarning("WinUI not found.");
        }
    }

    public void ShowWinUI()
    {
        FindReferences(); // Pastikan semua referensi diperbarui sebelum ditampilkan
        if (WinUI != null) WinUI.SetActive(true);
        if (winText != null)
        {
            winText.gameObject.SetActive(true);
            winText.text = "You Win!";
        }
        else
        {
            Debug.LogWarning("Unable to show winText as it is null.");
        }
    }

    public void HideWinUI()
    {
        FindReferences(); // Pastikan semua referensi diperbarui sebelum disembunyikan
        if (WinUI != null) WinUI.SetActive(false);
        if (winText != null) winText.gameObject.SetActive(false);
        else
        {
            Debug.LogWarning("Unable to hide winText as it is null.");
        }
    }
}
