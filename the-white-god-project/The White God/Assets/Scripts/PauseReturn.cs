using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseReturn : MonoBehaviour {

    public GameObject player;

    public void Return()
    {
        if (MusicScript.instance.music.isPlaying == false)
        {
            MusicScript.instance.music.Play();
        }
        SceneManager.LoadScene("Start");
        Destroy(player);
    }
}
