using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(2);
    }
    public void Settings()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Debug.Log("Exiting the game.");
        Application.Quit();
    }
}