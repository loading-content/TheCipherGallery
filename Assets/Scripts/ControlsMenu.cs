using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ControlsMenu : MonoBehaviour
{
    public GameObject ControlsMenuUI;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            if (ControlsMenuUI.activeInHierarchy)
            {
                Hide();
            }
            else
            {
                Show();
                Debug.Log("turned on ;)");
            }
        }
    }
    public void Hide()
    {
        ControlsMenuUI.SetActive(false);
    }
    private void Show()
    {
        ControlsMenuUI.SetActive(true);
    }
}
