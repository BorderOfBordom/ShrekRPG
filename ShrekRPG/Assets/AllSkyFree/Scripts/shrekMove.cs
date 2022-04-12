using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shrekMove : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 forward = transform.forward;
            controller.Move(forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 left = -transform.right;
            controller.Move(left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 right = transform.right;
            controller.Move(right * speed * Time.deltaTime);
        }
    }
}
