using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePages : MonoBehaviour
{
    public GameObject cleared;
    public bool clear;
    void OnEnable()
    {
        Debug.Log("checkcheck");
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
