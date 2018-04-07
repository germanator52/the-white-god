using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleControllerScript : MonoBehaviour {

    public static PuzzleControllerScript instance;

    public bool password = false;
    public GameObject stairway;
    public GameObject stairwayCover;

    private void Start()
    {
        instance = this;
    }

    private void Update()
    {
        
    }
}
