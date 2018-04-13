using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownEntryScript : MonoBehaviour {

    /*public static TownEntryScript instance;

    public GameObject fadeIn;
    public GameObject mainCamera;
    public GameObject canvas;
    public GameObject fadeOut;

    Animator fadeInAnim;
    Animator cameraAnim;
    Animator fadeOutAnim;

	// Use this for initialization
	void Start () {
        Debug.Log(DoorManagerScript.instance.townEntry);
        instance = this;
        fadeInAnim = fadeIn.GetComponent<Animator>();
        cameraAnim = mainCamera.GetComponent<Camera>().GetComponent<Animator>();
        fadeOutAnim = fadeOut.GetComponent<Animator>();
        if (DoorManagerScript.instance.townEntry == false)
        {
            StartCoroutine(Cutscene());
        }
	}
	
	// Update is called once per frame
	void Update () {

    }

    IEnumerator Cutscene()
    {
        fadeIn.SetActive(true);
        DoorManagerScript.instance.townEntry = true;
        Debug.Log(DoorManagerScript.instance.townEntry);
        FollowPlayer.instance.cutscene = true;
        fadeInAnim.Play("Fade_In");
        yield return new WaitForSeconds(0.5f);
        cameraAnim.Play("Town_Cutscene");
        yield return new WaitForSeconds(9.0f);
        canvas.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        fadeOutAnim.Play("Fade_Out");
        FollowPlayer.instance.cutscene = false;
        yield return new WaitForSeconds(4.0f);
        canvas.SetActive(false);
        fadeIn.SetActive(false);
        fadeOut.SetActive(false);
    }*/
}
