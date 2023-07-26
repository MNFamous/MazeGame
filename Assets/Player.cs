using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody body;
    public float speed;
    public Camera cam;
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        body.velocity = MovePlayerCamera()*speed;
        //body.rotation = cam.transform.rotation;
        if (Input.GetKeyDown("space"))
        {
            body.velocity = Vector3.zero;
        }
    }
    Vector3 MovePlayerCamera()
    {
        float playerVertical = Input.GetAxisRaw("Vertical");
        float playerHorizontal = Input.GetAxisRaw("Horizontal");

        Vector3 forward = cam.transform.forward;
        Vector3 right = cam.transform.right;
        forward.y = 0;
        right.y = 0;

        forward = forward.normalized;
        right = right.normalized;

        Vector3 forwardInput = playerVertical * forward;
        Vector3 rightInput = playerHorizontal * right;

        Vector3 cameraRelative = forwardInput + rightInput;
        return cameraRelative;
    }
}
