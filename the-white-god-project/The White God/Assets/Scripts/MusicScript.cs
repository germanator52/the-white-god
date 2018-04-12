using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicScript : MonoBehaviour {

    public static MusicScript instance;

    public AudioSource music;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        instance = this;
        music.Play();
        SceneManager.LoadScene("Start");
    }

    void Update()
    {

    }
}
