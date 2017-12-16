using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{ 

    [SerializeField]
    Transform mTarget;

    float kFollowSpeed = 10.0f;
    float stepOverThreshold = 0.10f;

    void Update ()
    { 
        if(mTarget != null)
        {
            Vector3 targetPosition = new Vector3(mTarget.transform.position.x, mTarget.transform.position.y, transform.position.z);
    Vector3 direction = targetPosition - transform.position;

           
                transform.position = targetPosition;
            }
        }
    }
