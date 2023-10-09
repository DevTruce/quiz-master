using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Question", menuName = "Quiz Question", order = 0)]
public class QuestionSO : ScriptableObject
{
    ////////////////////////////////////////////
    //// Creating input for questions

    [TextArea(2, 6)] // min and max amount of characters
    [SerializeField]
    string question = "Enter New Question Text Here";

    [SerializeField]
    string[] answers = new string[4];

    [SerializeField]
    int correctAnswerIndex;

    ////////////////////////////////////////////
    //// Getter Method (read only access)
    public string GetQuestion()
    {
        return question;
    }

    public string GetAnswer(int index)
    {
        return answers[index];
    }

    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }
}
