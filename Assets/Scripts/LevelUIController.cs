using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelUIController : MonoBehaviour
{
    public int Lives;
    public int Score;
    public float TotalTime;
    public TextMeshProUGUI LivesLabel;
    public TextMeshProUGUI ScoreLabel;
    public TextMeshProUGUI TimeLabel;

    void Update ()
    {
        TotalTime += Time.deltaTime;

        LivesLabel.text = "Lives: " + Lives;
        ScoreLabel.text = "Score: " + Score;
        TimeLabel.text = "Time: " + TotalTime.ToString("0.0") + "s";
    }

    public void Kill()
    {
        // Kill the player once, if it reaches 0, transition to a game over screen
        Lives--;
        if (Lives == 0)
            SceneManager.LoadScene("GameOver");
    }

    public void Collect()
    {
        Score++;
        if (Score==5)
        {
            Lives++;
            Score = 0;
        }
    }
}
