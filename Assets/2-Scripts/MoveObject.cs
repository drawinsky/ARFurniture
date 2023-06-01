using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private GameObject activeObject;
    private float speedModifier = 0.0005f;
    private Vector3 translationVector;

    // Update is called once per frame
    void Update()
    {
        // Object movement logic within the Update function
        if (Input.GetTouch(0).phase == TouchPhase.Moved && activeObject != null)
        {
        // Convert X-Y touch movement to object translation in world space
        translationVector = new Vector3(Camera.main.transform.forward.x, 0f, Camera.main.transform.forward.z);
        activeObject.transform.Translate(translationVector * Input.GetTouch(0).deltaPosition.y * speedModifier, Space.World);

        translationVector = new Vector3(Camera.main.transform.right.x, 0f, Camera.main.transform.right.z);
        activeObject.transform.Translate(translationVector * Input.GetTouch(0).deltaPosition.x * speedModifier, Space.World);
        }
    }
}
