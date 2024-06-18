using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRadio : MonoBehaviour
{
    // Variable to track whether the radio is on or off
    private bool isRadioOn = false;
    // Reference to the AudioSource component
    public AudioSource audioSource;
    // Update is called once per frame
    void Update()
    {
        // Check if the 'R' key is pressed
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Toggle the radio state
            isRadioOn = !isRadioOn;
            // Call a function to update the radio state
            UpdateRadioState();
        }
    }
    // Function to update the radio state
    void UpdateRadioState()
    {
        if (isRadioOn)
        {
            // Turn on the radio (play audio)
            if (audioSource != null && !audioSource.isPlaying)
            {
                audioSource.Play();
            }
            Debug.Log("Radio is turned on");
        }
        else
        {
            // Turn off the radio (stop audio)
            if (audioSource != null && audioSource.isPlaying)
            {
                audioSource.Stop();
            }
            Debug.Log("Radio is turned off");
        }
    }
}