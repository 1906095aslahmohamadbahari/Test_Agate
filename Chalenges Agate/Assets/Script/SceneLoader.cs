using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void SceneMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void SceneNomer1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void SceneNomer2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }

    public void SceneNomer3()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(3);
    }

    public void SceneNomer4()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(4);
    }

    public void SceneNomer5()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(5);
    }

    public void SceneNomer6()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(6);
    }

    public void SceneNomer78()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(7);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
