using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int correctAnswers = 0;
    int questionsSeen = 0;

    public int GetCorrectAnswers()
    {
        return correctAnswers;
    }

    public void InrementCorrectAnswers()
    {
        correctAnswers++;
    }

    public int GetQuestionsSeen()
    {
        return questionsSeen;
    }

    public void InrementQuestionsSeen()
    {
        questionsSeen++;
    }

    public int CalculateScore()
    {
        Debug.Log("correct answers: " + correctAnswers);
        Debug.Log("questions seen: " + questionsSeen);
        return Mathf.RoundToInt(correctAnswers / (float)questionsSeen * 100);
    }
}
