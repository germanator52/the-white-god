using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour {

    public static PauseScript instance;

    public GameObject pauseCanvas;

    bool pause;

    void Start()
    {
        instance = this;
        pause = false;
    }

    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            if (pause == false)
            {
                pause = true;
                Time.timeScale = 0;
                pauseCanvas.SetActive(true);
            }
        }
    }

    public void Continue()
    {
        pause = false;
        Time.timeScale = 1;
        pauseCanvas.SetActive(false);
    }
}
