using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shrekCam : MonoBehaviour
{
    public float mouseSensitvity = 1.7f;
    public Transform shrekBody;
    float xRot = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitvity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitvity;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        shrekBody.Rotate(Vector3.up * mouseX);
    }
}
