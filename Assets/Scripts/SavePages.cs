using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePages : MonoBehaviour
{
    public GameObject cleared;
    public bool clear;

    [SerializeField] private string self;
    void OnEnable()
    {
        self = gameObject.name;
        clear = (PlayerPrefs.GetInt(self) != 0);
        Debug.Log("checkcheck");
        Debug.Log(self);

        if (clear == true)
        {
            cleared.SetActive(true);
        }
        else
        {
            cleared.SetActive(false);
        }
    }
}
