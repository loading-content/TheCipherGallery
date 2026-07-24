using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseMenuUI;
    public GameObject ControlsMenuUI;
    public GameObject NotebookUI;
    public PlayerController playerController;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (!PauseMenuUI.activeInHierarchy && !ControlsMenuUI.activeInHierarchy && !NotebookUI.activeInHierarchy)
            {
                Pause();
                Debug.Log("turned on ;)");
            }
        }
    }
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        playerController.canMove = true;
    }
    private void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0.5f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        playerController.canMove = false;
    }
    public void Controls()
    {
        PauseMenuUI.SetActive(false);
        ControlsMenuUI.SetActive(true);
    }
    public void Back()
    {
        ControlsMenuUI.SetActive(false);
        PauseMenuUI.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
