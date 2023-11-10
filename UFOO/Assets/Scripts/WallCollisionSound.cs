using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WallCollisionSound : MonoBehaviour
{
    public AudioClip wallHitSound;  // Assign your sound clip in the Unity editor
    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component from the same GameObject
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // If there's no AudioSource component, add one
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the sound clip to the AudioSource component
        audioSource.clip = wallHitSound;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with a GameObject tagged as "Wall"
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Play the assigned sound clip
            audioSource.PlayOneShot(wallHitSound);
        }
    }
}

