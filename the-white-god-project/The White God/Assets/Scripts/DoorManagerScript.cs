using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManagerScript : MonoBehaviour {

    public static DoorManagerScript instance;

    public int doorID;

    Vector3 newTransform;

    public GameObject player;

    bool town;

    public bool townEntry;

	void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
        town = false;
    }

    private void Update()
    {
        player = GameObject.FindWithTag("Player");
    }

    public void SetID(int i)
    {
        if (i != 0)
        {
            doorID = i;
        }
        SavePlayerPosition();
    }

    void SavePlayerPosition()
    {
        if (doorID == 1)
        {
            Vector3 newVector = new Vector3(0, -3, 0);
            newTransform = newVector;
            PlayerMovement.instance.inside = true;
        } else if (doorID == 2)
        {
            Vector3 newVector = new Vector3(2, -3, -0.5f);
            newTransform = newVector;
            PlayerMovement.instance.inside = true;
        }
        else if (doorID == 3)
        {
            Vector3 newVector = new Vector3(0, -2, 0);
            newTransform = newVector;
            PlayerMovement.instance.inside = true;
        }
        else if (doorID == 4)
        {
            Vector3 newVector = new Vector3(2, -4, 0);
            newTransform = newVector;
            PlayerMovement.instance.inside = true;
        }
        else if (doorID == 5)
        {
            Vector3 newVector = new Vector3(0, -14, 0);
            newTransform = newVector;
            PlayerMovement.instance.inside = true;
        }
        else if (doorID == 6)
        {
            Vector3 newVector = new Vector3(17, -7, 0);
            newTransform = newVector;
            PlayerMovement.instance.inside = false;
        }
        else if (doorID == 7)
        {
            Vector3 newVector = new Vector3(46.5f, 16, 0);
            newTransform = newVector;
            PlayerMovement.instance.inside = false;
        }
        else if (doorID == 8)
        {
            Vector3 newVector = new Vector3(52, -8, 0);
            newTransform = newVector;
            PlayerMovement.instance.inside = false;
        }
        else if (doorID == 9)
        {
            Vector3 newVector = new Vector3(51.5f, -20, 0);
            newTransform = newVector;
            PlayerMovement.instance.inside = false;
        }
        else if (doorID == 10)
        {
            Vector3 newVector = new Vector3(74.5f, -15, 0);
            newTransform = newVector;
            PlayerMovement.instance.inside = false;
        }

        SetPlayerTransform();
    }

    public void SetPlayerTransform()
    {
        player.transform.position = newTransform;
    }
}
