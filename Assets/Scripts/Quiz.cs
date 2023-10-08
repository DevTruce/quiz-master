using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuestionSO question;
    [SerializeField] GameObject[] answerButtons;
    int correctAnswerIndex;
    [SerializeField] Sprite defaultAnswerSprite;
    [SerializeField] Sprite correctAnswerSprite;

    void Start()
    {
        // find and display question
        questionText.text = question.GetQuestion();


       // find and display possible answers 
        for (int i = 0; i < answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = question.GetAnswer(i);
        }
    }

    public void onAnswerSelected(int index) 
    {
        Image buttonImage;

        // correct answer
        if (index == question.GetCorrectAnswerIndex())
        {
            questionText.text = "Correct answer";
            buttonImage = answerButtons[index].GetComponent<Image>(); // get image component for selected button 
            buttonImage.sprite = correctAnswerSprite; // update button sprite
        } else 
        {
            correctAnswerIndex = question.GetCorrectAnswerIndex(); // get the correct answer
            string correctAnswer = question.GetAnswer(correctAnswerIndex); // store the correct answer 
            questionText.text = "Sorry, the correct answer was: \n" + correctAnswer; 
            buttonImage = answerButtons[correctAnswerIndex].GetComponent<Image>(); // get image component for selected button
            buttonImage.sprite = correctAnswerSprite; // update button sprite

        }
    }
}
