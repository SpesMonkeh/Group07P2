using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleportX : MonoBehaviour
{
    public List<Transform> teleportPositions; // List of teleport positions
    private int currentTeleportIndex = 0; // Index of the current teleport position

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collider's tag is "Teleporter" and if there are teleport positions available
        if (collision.gameObject.CompareTag("TeleporterX") && teleportPositions.Count > 0)
        {
            Transform nextPosition = teleportPositions[currentTeleportIndex]; // Get the next teleport position

            transform.position = nextPosition.position; // Teleport to the position of the next teleport position
            transform.rotation = Quaternion.identity; // Set the rotation to identity (straight up)

            // Increment the teleport index for the next teleport
            currentTeleportIndex = (currentTeleportIndex + 1) % teleportPositions.Count;
        }
    }
}
