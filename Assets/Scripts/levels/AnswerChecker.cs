using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnswerChecker : MonoBehaviour
{
    [SerializeField] InputField inputField;
    [SerializeField] Text resultText;
    public string answer;

    public GameObject answerInputUI;
    public void ValidateInput()
    {
        string input = inputField.text;
        if (input == answer)
        {
            Scene scene = SceneManager.GetActiveScene();
            resultText.text = "yes, " + input;
            resultText.color = Color.green;
            PlayerPrefs.SetInt(scene.name, 1);
        }

    }
    public void buttonPressed()
    {
        if (!answerInputUI.activeInHierarchy)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }
    private void Resume()
    {
        answerInputUI.SetActive(false);
    }
    private void Pause()
    {
        answerInputUI.SetActive(true);
    }
    public void backToGallery()
    {
        SceneManager.LoadScene(0);
    }
}
