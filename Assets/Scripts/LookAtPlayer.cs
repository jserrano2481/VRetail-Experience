using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public Transform player;
    public float lookTime = 5f;

    private float currentLookTime;

    private void Update()
    {
        if (player != null)
        {
            // Rotate the object to face the player
            transform.LookAt(player.position);

            // Decrease the look time
            currentLookTime -= Time.deltaTime;

            // Check if the look time has expired
            if (currentLookTime <= 0f)
            {
                // Reset the look time
                currentLookTime = lookTime;

                // Set the player to null so that the object stops looking at the player
                player = null;
            }
        }
    }

    public void StartLookingAtPlayer(Transform playerTransform)
    {
        // Set the player to look at
        player = playerTransform;

        // Start the look time
        currentLookTime = lookTime;
    }
}
