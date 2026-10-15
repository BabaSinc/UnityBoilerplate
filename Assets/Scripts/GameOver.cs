using UnityEngine;
// Add this using command
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void GoToMainMenu()
    {
        
        SceneManager.LoadScene("MainMenu");
    }

    public void Exit()
    {
        Application.Quit();
    }
}