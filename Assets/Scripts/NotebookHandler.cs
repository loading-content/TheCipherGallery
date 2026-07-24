using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookHandler : MonoBehaviour
{
    public GameObject PauseMenuUI;
    public GameObject ControlsMenuUI;
    public GameObject NotebookUI;
    public PlayerController playerController;

    [SerializeField] private GameObject[] pages;
    private int currentPageIndex = 0;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.N))
        {
            if (!PauseMenuUI.activeInHierarchy && !ControlsMenuUI.activeInHierarchy && !NotebookUI.activeInHierarchy)
            {
                Open();
                Debug.Log("turned on ;)");
            }
        }
    }
    public void Close()
    {
        NotebookUI.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        playerController.canMove = true;
    }
    public void Open()
    {
        NotebookUI.SetActive(true);
        pages[currentPageIndex].SetActive(true);
        Time.timeScale = 0.5f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        playerController.canMove = false;
    }
    public void Next()
    {
        pages[currentPageIndex].SetActive(false);
        if (currentPageIndex < pages.Length - 1)
        {
            currentPageIndex++;
            Debug.Log(currentPageIndex);
            pages[currentPageIndex].SetActive(true);
        }
        else if (currentPageIndex >= pages.Length - 1)
        {
            currentPageIndex = 0;
            Debug.Log(currentPageIndex);
            pages[currentPageIndex].SetActive(true);
        }

    }
    public void Previous()
    {
        pages[currentPageIndex].SetActive(false);
        if (currentPageIndex > 0)
        {
            currentPageIndex--;
            Debug.Log(currentPageIndex);
            pages[currentPageIndex].SetActive(true);
        }
        else if (currentPageIndex == 0)
        {
            currentPageIndex = pages.Length - 1;
            Debug.Log(currentPageIndex);
            pages[currentPageIndex].SetActive(true);
        }
    }
}
