using UnityEngine;

public class falling_detect : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Check if the falling object touches the player
        {
            Debug.Log("❌ Player hit! GAME OVER!");
            StopGame();
        }
    }

    void StopGame()
    {
        Time.timeScale = 0f; // ❌ Freeze the game
        Debug.Log("⏸️ Game Paused!");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) // Press 'R' to restart
        {
            RestartGame();
        }
    }

    void RestartGame()
    {
        Time.timeScale = 1f; // Resume the game
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name); // Reload scene
    }
}