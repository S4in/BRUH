using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz_Manager : MonoBehaviour
{
    //[SerialzeField]
    private List<Question> questions;

    private Question selectedQuetion;

    public void Start()
    {
        SelectQuestion();
    }

    private void SelectQuestion()
    {
        //get the random number 
        int val = UnityEngine.Random.Range(0, questions.Count);
        //set the selectedQuetion
        selectedQuetion = questions[val];
    }
    private void Answer()
    {

    }
    private void Update()
    {

    }

    //Datastructure for storeing the quetions data
    [System.Serializable]
    public class Question
    {
        public string questionInfo;         //question text
        public List<string> options;        //options to select
        public string correctAns;           //correct option
    }

    [System.Serializable]
    public enum QuestionType
    {
        TEXT
    }
}
