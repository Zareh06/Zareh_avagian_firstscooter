using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerarotation : MonoBehaviour
{
    public Transform player;
    public float speed = 400f;
    public float yRotaiton = 10f;
    public float xRotaiton = 10f;
    public Camera cam;

    private float xMouse;
    private float yMouse;
   
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        yMouse = Input.GetAxis("Mouse Y") * Time.deltaTime;
        xMouse = Input.GetAxis ("Mouse X") * Time.deltaTime;

        // up down rotation
        xRotaiton -= yMouse;
        xRotaiton = Mathf.Clamp(xRotaiton, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotaiton * 100, 0f, 0f);

        // sideways rotation
        player.Rotate(Vector3.up * xMouse * yRotaiton);
    }
}
