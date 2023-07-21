using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    float xRotation;
    public float mouseSensivity = 1000.0f;
    public GameObject player;
    float mouseX;
    float mouseY;
    // Start is called before the first frame update
    void Start()
    {
        xRotation = transform.rotation.eulerAngles.x;
    }
    void cameraMovement()
    {
        mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensivity;
        mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensivity;

        xRotation -= mouseY;

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        player.transform.Rotate(Vector3.up * mouseX);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(2))
        {
            cameraMovement();
        }
    }
}
