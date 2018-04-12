using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    public void StartGame()
    {
        if (MusicScript.instance.music.isPlaying == true)
        {
            MusicScript.instance.music.Stop();
        }
        SceneManager.LoadScene("Awaken");
    }

    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void Return()
    {
        if (MusicScript.instance.music.isPlaying == false)
        {
            MusicScript.instance.music.Play();
        }
        SceneManager.LoadScene("Start");
    }

    public void About()
    {
        SceneManager.LoadScene("About");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
