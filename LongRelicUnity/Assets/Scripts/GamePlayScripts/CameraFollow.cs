using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public Vector3 offset;
    public float smoothFactor;

    void FixedUpdate()
    {
       FollowPlayer(target);
    } 

    void FollowPlayer(Transform playerTarget)
    {
        Vector3 targetPosition = playerTarget.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, playerTarget.position, smoothFactor * Time.fixedDeltaTime ); 
        transform.position = playerTarget.position + offset;
    }
}
