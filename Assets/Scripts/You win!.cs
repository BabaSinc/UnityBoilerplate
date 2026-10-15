using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWin : MonoBehaviour
{
    public void GoToLevel2()
    {
        
        SceneManager.LoadScene("Level2");
    }

    public void GoToMainMenu()
    {

        SceneManager.LoadScene("MainMenu");
    }
}
