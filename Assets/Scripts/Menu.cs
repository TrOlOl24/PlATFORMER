using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("GameplayScene");
    }

    public void ControlScene()
    {
        SceneManager.LoadScene("ControlScene");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void ExitButton()
    {
        Debug.Log("Exit Game!");
        Application.Quit();
    }
}
