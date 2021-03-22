using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Manager : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene(0); // Loads MainMenu
    }
    public void Play()
    {
        SceneManager.LoadScene(2); //Loads GameScene
    }
    public void Controls()
    {
        SceneManager.LoadScene(1); //Loads Control Scene
    }
    
    public void Quit()
    {
        Application.Quit(); // Quits Application
        Debug.Log("Application Has Quitted");
    }

    
}
