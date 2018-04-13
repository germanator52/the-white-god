using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public static FollowPlayer instance;

    public bool cutscene = false;

    public Transform target;

    public float smoothSpeed = 0.125f;

    public Vector3 offset;

    private void Start()
    {
        instance = this;
    }

    private void Update()
    {
            target = GameObject.FindWithTag("Player").transform;
    }

    private void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
