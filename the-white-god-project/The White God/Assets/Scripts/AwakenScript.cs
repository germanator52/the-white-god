using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AwakenScript : MonoBehaviour {

    public AudioSource awaken;

    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject button;
    public GameObject player;

    Animator anim1;
    Animator anim2;
    Animator anim3;
    Animator anim4;

    private void Awake()
    {
        anim1 = text1.GetComponent<Animator>();
        anim2 = text2.GetComponent<Animator>();
        anim3 = text3.GetComponent<Animator>();
        anim4 = text4.GetComponent<Animator>();
    }

    private void Start()
    {
        awaken.Play();
        StartCoroutine(Text());
    }

    IEnumerator Text()
    {
        yield return new WaitForSeconds(15.0f);
        anim1.Play("Awaken_Text");
        yield return new WaitForSeconds(3.0f);
        anim2.Play("Awaken_Text");
        yield return new WaitForSeconds(3.0f);
        anim3.Play("Awaken_Text");
        yield return new WaitForSeconds(3.0f);
        anim4.Play("Awaken_Text");
        yield return new WaitForSeconds(3.0f);
        button.SetActive(true);
    }

    public void Awaken()
    {
        player.SetActive(true);
        SceneManager.LoadScene("PoliceStation");
    }
}
