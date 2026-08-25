using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaintingInteractable : MonoBehaviour
{
    [SerializeField] private int sceneIndex;

    private bool playerInRange = false;
    public PlayerController playerController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("Entered hehe");
        }
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
        else if (!playerController.canMove)
        {
            Debug.Log("Player cant move");
            return;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(sceneIndex);
            // SceneManager.LoadScene(1);
        }
    }
}
