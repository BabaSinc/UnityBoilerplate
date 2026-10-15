using UnityEngine;
// Add this using command
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void GoToLevel()
    { 
        //Level1 is the name of the other scene I want to load
        //For this to work, Level1 is added to my list of scene
        SceneManager.LoadScene("Level1");
    }

   public void Exit()
    {
        Application.Quit();
    }
}
