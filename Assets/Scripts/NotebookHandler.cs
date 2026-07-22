using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookHandler : MonoBehaviour
{
    public GameObject NotebookUI;
    public PlayerController playerController;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.N))
        {
            if (!NotebookUI.activeInHierarchy)
            {
                Pause();
                Debug.Log("turned on ;)");
            }
        }
    }
    public void Back()
    {
        NotebookUI.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        playerController.canMove = true;
    }
    private void Pause()
    {
        NotebookUI.SetActive(true);
        Time.timeScale = 0.5f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        playerController.canMove = false;
    }
}
