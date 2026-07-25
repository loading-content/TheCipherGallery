using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetLevelData : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            PlayerPrefs.DeleteKey("tutorial");
            PlayerPrefs.DeleteKey("level1");
            PlayerPrefs.DeleteKey("level2");
            PlayerPrefs.DeleteKey("level3");
            PlayerPrefs.DeleteKey("level4");
            PlayerPrefs.DeleteKey("level5");
            PlayerPrefs.DeleteKey("level6");
            PlayerPrefs.DeleteKey("level7");
            PlayerPrefs.DeleteKey("level8");
            PlayerPrefs.DeleteKey("level9");
            PlayerPrefs.DeleteKey("level10");
            PlayerPrefs.DeleteKey("level11");
            PlayerPrefs.DeleteKey("level12");
            PlayerPrefs.DeleteKey("level13");
            PlayerPrefs.DeleteKey("level14");
            PlayerPrefs.DeleteKey("level15");
        }
    }
}
