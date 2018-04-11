using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectColliderScript : MonoBehaviour {

    public static ObjectColliderScript instance;

    public GameObject canvas;
    public Text text;
    public string[] textArray;

    public AudioSource doorLock;
    public AudioSource rumble;

    public GameObject policeCanvas;
    public GameObject townHallFlyerCanvas;
    public GameObject dorisCanvas;
    public GameObject officeCanvas;
    public GameObject officeCanvas2;
    public GameObject convenienceStoreFlyerCanvas;
    public GameObject bibleCanvas;
    public GameObject passwordCanvas;

    int objectID;
    string display;

    bool dorisNote = false;
    bool churchPainting = false;
    bool bible = false;

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
                } else if (churchPainting == true)
                {
                    TextControlScript.instance.ChangeText(16);
                    churchPainting = false;
                } else if (bible == true)
                {
                    bible = false;
                    TextControlScript.instance.ChangeText(17);
                }
                else if (objectID != 3 && objectID != 10 && objectID != 13 && objectID != 14 && objectID != 17 && objectID != 20 && objectID != 24)
                {
                    Debug.Log(objectID);
                    text.text = "";
                    canvas.SetActive(false);
                }
            }
        }
    }

    void CheckForButtons()
    {
        if (objectID == 2)
        {
            doorLock.Play();
        } else if (objectID == 3)
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
        } else if (objectID == 17)
        {
            PlayerMovement.instance.speed = 0.0f;
            convenienceStoreFlyerCanvas.SetActive(true);
        } else if (objectID == 20)
        {
            PlayerMovement.instance.speed = 0.0f;
            churchPainting = true;
        } else if (objectID == 24)
        {
            PlayerMovement.instance.speed = 0.0f;
            bible = true;
        }
    }

    public void Unpause(int i)
    {
        StartCoroutine(UnpauseRoutine(i));
    }

    IEnumerator UnpauseRoutine(int i)
    {
        if (i == 1)
        {
            policeCanvas.SetActive(false);
        }
        else if (i == 2)
        {
            townHallFlyerCanvas.SetActive(false);
        }
        else if (i == 3)
        {
            dorisCanvas.SetActive(false);
        }
        else if (i == 4)
        {
            officeCanvas2.SetActive(false);
        }
        else if (i == 5)
        {
            officeCanvas.SetActive(false);
        }
        else if (i == 6)
        {
            convenienceStoreFlyerCanvas.SetActive(false);
        }
        else if (i == 7)
        {
            bibleCanvas.SetActive(false);
        }
        else if (i == 8)
        {
            passwordCanvas.SetActive(false);
        }
        else if (i == 9)
        {
            rumble.Play();
            yield return new WaitForSeconds(3.0f);
            rumble.Stop();
        }
        canvas.SetActive(false);
        text.text = "";
        PlayerMovement.instance.speed = 2.0f;
    }
}
