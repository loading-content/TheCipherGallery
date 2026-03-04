using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingInteractable : MonoBehaviour
{
    private bool playerInRange = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            playerInRange = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            playerInRange = false;
    }

    public void OnClick()
    {
        if (!playerInRange)
        {
            Debug.Log("Player not in range");
            return;
        }

        Debug.Log("Opening scene for " + gameObject.name);
        // Load scene here
    }
}
