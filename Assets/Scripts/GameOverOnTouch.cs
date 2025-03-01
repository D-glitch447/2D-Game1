using UnityEngine;
using TMPro;

public class GameOverOnTouch : MonoBehaviour
{
    public TextMeshProUGUI loseText; // Assign in Inspector

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(gameObject.name + " touched " + collision.gameObject.name); // Check what it's colliding with

        if (collision.CompareTag("Player")) // Make sure Player has the correct tag
        {
            Debug.Log("GAME OVER! Player was hit.");
            ShowGameOverMessage();
        }
    }

    void ShowGameOverMessage()
    {
        if (loseText != null)
        {
            loseText.gameObject.SetActive(true);
            Debug.Log("LoseText should now be visible.");
        }
        else
        {
            Debug.LogError("LoseText UI is not assigned in the Inspector!");
        }

        Time.timeScale = 0f; // Freeze the game
    }
}
