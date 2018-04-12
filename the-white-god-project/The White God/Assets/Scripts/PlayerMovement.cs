using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public static PlayerMovement instance;

    public float speed = 2.0f;

    public bool inside = true;

    public AudioSource footsteps;
    public AudioSource door;
    public AudioSource stairs;
    public AudioSource outdoorFootsteps;


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        instance = this;
    }

    private void Update()
    {
        if (inside == true)
        {
            outdoorFootsteps.Pause();
        }

        if (inside == false)
        {
            footsteps.Pause();
        }

        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += move * speed * Time.deltaTime;
        if (Input.GetAxis("Horizontal") == 0.0 && Input.GetAxis("Vertical") == 0.0)
        {
            if (footsteps.isPlaying == true || outdoorFootsteps.isPlaying == true)
            {
                footsteps.Pause();
                outdoorFootsteps.Pause();
            }
        } else
        {
            if (inside == true)
            {
                if (footsteps.isPlaying == false)
                {
                    footsteps.Play();
                }
            } else if (inside == false)
            {
                if (outdoorFootsteps.isPlaying == false)
                {
                    outdoorFootsteps.Play();
                }
            }
        }
    }

    public void Door()
    {
        door.Play();
    }

    public void Stairs()
    {
        stairs.Play();
        StartCoroutine(PlayerDestroy());
    }

    IEnumerator PlayerDestroy()
    {
        yield return new WaitForSeconds(5.0f);
        Destroy(gameObject);
    }
}
