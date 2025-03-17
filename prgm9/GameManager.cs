using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI chancesText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    public int totalCubes = 5;
    public float levelTime = 10f;
    public int maxChances = 3;

    private int score = 0;
    private float timer;
    private int chances;
    private bool gameOver = false;

    void Start()
    {
        timer = levelTime;

        if (PlayerPrefs.HasKey("Chances"))
            chances = PlayerPrefs.GetInt("Chances"); // Load previous chances
        else
            chances = maxChances; // First time

        UpdateUI();
    }

    void Update()
    {
        if (gameOver) return; // Stop updating if game is over

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            EndLevel();
        }

        UpdateUI();
    }

    public void CollectCube(GameObject cube)
    {
        if (gameOver) return;

        score += 10;
        Destroy(cube);
        totalCubes--;

        if (totalCubes == 0)
        {
            if (SceneManager.GetActiveScene().buildIndex == 1) // Check if it's Level 2
            {
                gameOver = true;
                Debug.Log("You Won! Game Completed.");
                timerText.text = "You Won!";
                PlayerPrefs.DeleteKey("Chances"); // Reset for new game
                return;
            }
            else
            {
                LoadNextLevel();
            }
        }

        UpdateUI();
    }

    void UpdateUI()
    {
        scoreText.text = "Score: " + score;
        chancesText.text = "Chances Left: " + Mathf.Max(0, chances); // Ensure it never goes negative
        timerText.text = gameOver ? "Game Over!" : "Time Left: " + Mathf.Ceil(timer);
    }

    void EndLevel()
    {
        chances--;

        if (chances <= 0)
        {
            gameOver = true;
            PlayerPrefs.DeleteKey("Chances"); // Reset for a new game
            Debug.Log("Game Over!");
            timerText.text = "Game Over!";
            return; // Stop further execution
        }

        PlayerPrefs.SetInt("Chances", chances);
        PlayerPrefs.Save();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene(1); // Load Level 2
    }
}
