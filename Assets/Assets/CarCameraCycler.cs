using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    // Array to hold the cameras
    public Camera[] cameras;
    // Variable to keep track of the current active camera index
    private int currentCameraIndex;
    // Start is called before the first frame update
    void Start()
    {
        // Disable all cameras except the first one
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(i == 0);
        }
        currentCameraIndex = 0;
    }
    // Update is called once per frame
    void Update()
    {
        // Check if the 'C' key is pressed
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Cycle to the next camera
            currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;
            // Activate the new camera and deactivate the others
            for (int i = 0; i < cameras.Length; i++)
            {
                cameras[i].gameObject.SetActive(i == currentCameraIndex);
            }
            Debug.Log("Switched to camera: " + currentCameraIndex);
        }
    }
}