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
            resultText.text = "yes, " + input;
            resultText.color = Color.green;
        }
        else
        {
            resultText.text = "hmm nope";
            resultText.color = Color.red;
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
