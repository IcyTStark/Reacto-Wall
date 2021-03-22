using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0); //Returns to Main-Menu
    }

    public void PlayTheGame()
    {
        SceneManager.LoadScene(2); //Begins the Game & Loads Game Level
    }

    public void ControlsPage()
    {
        SceneManager.LoadScene(1); //Takes toy to Controls Scene
    }

    public void Exit()
    {
        Application.Quit(); //Quits the Application
        Debug.Log("Application has quit"); //For Debugging purposes
    }
}
