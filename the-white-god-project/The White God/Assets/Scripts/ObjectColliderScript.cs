using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectColliderScript : MonoBehaviour {

    public static ObjectColliderScript instance;

    public GameObject canvas;
    public Text text;
    public string[] textArray;

    public GameObject policeCanvas;
    public GameObject townHallFlyerCanvas;
    public GameObject dorisCanvas;
    public GameObject officeCanvas;
    public GameObject officeCanvas2;

    int objectID;
    string display;

    bool dorisNote = false;

    private void Awake()
    {
        instance = this;
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag != "Player")
        {
            if (Input.GetKeyDown("e"))
            {
                if (col.gameObject.tag == "Object")
                {
                    objectID = col.gameObject.GetComponent<ObjectScript>().objectID;
                    display = textArray[objectID];
                    text.text = display;
                    canvas.SetActive(true);
                    CheckForButtons();
                }
            }
        }
    }

    private void Update()
    {
        if (canvas.activeSelf == true)
        {
            if (Input.GetKeyDown("return"))
            {
                if (dorisNote == true)
                {
                    TextControlScript.instance.ChangeText(7);
                    dorisNote = false;
                } else if (objectID != 3 && objectID != 10 && objectID != 13 && objectID != 14)
                {
                    text.text = "";
                    canvas.SetActive(false);
                }
            }
        }
    }

    void CheckForButtons()
    {
        if (objectID == 3)
        {
            PlayerMovement.instance.speed = 0.0f;
            policeCanvas.SetActive(true);
        } else if (objectID == 10)
        {
            PlayerMovement.instance.speed = 0.0f;
            townHallFlyerCanvas.SetActive(true);
        } else if (objectID == 13)
        {
            PlayerMovement.instance.speed = 0.0f;
            dorisNote = true;
        } else if (objectID == 14)
        {
            PlayerMovement.instance.speed = 0.0f;
            officeCanvas.SetActive(true);
        }
    }

    public void Unpause(int i)
    {
        if (i == 1)
        {
            policeCanvas.SetActive(false);
        } else if (i == 2)
        {
            townHallFlyerCanvas.SetActive(false);
        } else if (i == 3)
        {
            dorisCanvas.SetActive(false);
        } else if (i == 4)
        {
            officeCanvas2.SetActive(false);
        } else if (i == 5)
        {
            officeCanvas.SetActive(false);
        }
        canvas.SetActive(false);
        text.text = "";
        PlayerMovement.instance.speed = 2.0f;
    }
}
