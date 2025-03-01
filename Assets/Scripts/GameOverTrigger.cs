using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverTrigger : MonoBehaviour
{
    public TextMeshProUGUI winText; // Drag & drop "WinText" from Inspector

    void Start()
    {
        winText.gameObject.SetActive(false); // Hide at start
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Change if needed
        {
            Debug.Log("YOU WIN!");
            ShowWinMessage();
        }
    }

    void ShowWinMessage()
    {
        winText.gameObject.SetActive(true); // Show the text
        Time.timeScale = 0f; // Freeze the game
    }
}
