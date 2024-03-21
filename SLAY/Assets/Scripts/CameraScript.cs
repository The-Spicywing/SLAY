using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform target;

    public flaot smoothSpeed = 0.125f;
    public Vector3 offset;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if(target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
        else
        {
            return;
        }
    }
}
