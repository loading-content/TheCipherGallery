using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaintingInteractable : MonoBehaviour
{
    [SerializeField] private int sceneIndex;

    private bool playerInRange = false;

    private void OnTriggerEnter(Collider other)
    {
        playerInRange = true;
        Debug.Log("Entered hehe");
    }

    private void OnTriggerExit(Collider other)
    {
        playerInRange = false;
        Debug.Log("Exited :(");
    }

    public void OnClick()
    {
        Debug.Log(playerInRange);
        if (!playerInRange)
        {
            Debug.Log("Player not in range");
            return;
        }

        SceneManager.LoadScene(sceneIndex);
    }
}
