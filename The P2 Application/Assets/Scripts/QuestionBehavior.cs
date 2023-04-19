using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionBehavior : MonoBehaviour
{

    public TMP_InputField MainInputField;
    public string myText;
    public string RightAnswer;
    public string[] RightAnswers;
    public GameObject[] GDQuestionArray;
    public GameObject[] GeoQuestionArray= new GameObject[10];
    
    
    public GameObject[] FinishedQuestions;



    public void CheckRightAnswer()
    {
        myText = MainInputField.text;
        

        if (myText==RightAnswer)
        {
            Debug.Log("Correct");
        }
        else
        {
            Debug.Log("Wrong!");
        }

    }


   
    
    public void SpawnQuestion()
    {

        var questionIndex = Random.Range(0, GDQuestionArray.Length);
        var answerIndex = Random.Range(0, RightAnswers.Length);
        
        
        //while (FinishedQuestions[questionIndex] != null)
        {
            questionIndex = Random.Range(0, GDQuestionArray.Length);
        }
        

        if (questionIndex==answerIndex)
        {
            ActivateQuestion(questionIndex);
        }
        
        //FinishedQuestions[questionIndex] = GDQuestionArray[questionIndex];
    }

    public void ActivateQuestion(int index)
    {
        GDQuestionArray[index].SetActive(true);
    }

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
