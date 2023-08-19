using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void TutLevel_1()
    {
        SceneManager.LoadScene(1);
    }

    public void TutLevel_2()
    {
        SceneManager.LoadScene(2);
    }

    public void Level_1()
    {
        SceneManager.LoadScene(3);
    }

    public void Level_2()
    {
        SceneManager.LoadScene(4);
    }

    public void Level_3()
    {
        SceneManager.LoadScene(5);
    }

    /*public void Level_4()
    {
        SceneManager.LoadScene(4);
    }*/

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting Game");
    }
}
