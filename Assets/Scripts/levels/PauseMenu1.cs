using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PauseMenu1 : MonoBehaviour
{
    public GameObject PauseMenuUI;
    public GameObject ButtonsMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (!PauseMenuUI.activeInHierarchy && !ButtonsMenuUI.activeInHierarchy)
            {
                Pause();
                Debug.Log("turned on ;)");
            }
        }
    }
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
    }
    private void Pause()
    {
        PauseMenuUI.SetActive(true);
    }
    public void Buttons()
    {
        PauseMenuUI.SetActive(false);
        ButtonsMenuUI.SetActive(true);
    }
    public void Back()
    {
        ButtonsMenuUI.SetActive(false);
        PauseMenuUI.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
