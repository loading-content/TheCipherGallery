using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (PauseMenuUI.activeInHierarchy)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0.5f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
