using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void Home()
    {
        SceneManager.LoadScene("home");
    }
}
