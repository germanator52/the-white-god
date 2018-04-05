using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour {

    public string targetScene;


    public int doorNumber;

    private void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            DoorManagerScript.instance.SetID(doorNumber);
            SceneManager.LoadScene(targetScene);
        }
    }
}
