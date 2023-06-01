using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N_RotateObject : MonoBehaviour
{
    private GameObject activeObject;
    private float previousRotationAngle = 0f;
    private float currentRotationAngle = 0f;
    private float rotateSpeed = 100f;

    void Update()
    {
        // Initialize rotation angle for 2-finger object rotation
        previousRotationAngle = currentRotationAngle;
        // Check if user is touching with 2 finger and is not touching any UI
        if (Input.touchCount == 2 && !Input.GetTouch(0).position.IsPointOverUIObject() && !Input.GetTouch(1).position.IsPointOverUIObject())
        {
            currentRotationAngle = Mathf.Atan((Input.GetTouch(0).position.y - Input.GetTouch(1).position.y) / (Input.GetTouch(0).position.x - Input.GetTouch(1).position.x));
            if ((currentRotationAngle - previousRotationAngle) > 0)
            {
                activeObject.transform.Rotate(0, -rotateSpeed, 0);
            }
            if ((currentRotationAngle - previousRotationAngle) < 0)
            {
                activeObject.transform.Rotate(0, rotateSpeed, 0);
            }
        }
    }

}
