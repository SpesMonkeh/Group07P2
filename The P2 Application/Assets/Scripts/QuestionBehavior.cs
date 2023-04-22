using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionBehavior : MonoBehaviour
{

    public TMP_InputField MainInputField;
    [SerializeField] private TMP_InputField[] MainInputFields;
    [SerializeField] private string myText;
    public string RightAnswer;
    public string[] RightAnswers;
    public GameObject[] GDQuestionArray;
    public GameObject[] GeoQuestionArray= new GameObject[10];
    
    
    public GameObject[] FinishedQuestions= new GameObject[10];

    public GameManager GameManager;

    public void CheckRightAnswer(int answerArray)
    {
        myText = MainInputField.text;
        RightAnswer = RightAnswers[answerArray];
        

        if (myText==RightAnswer)
        {
            Debug.Log("Correct");
            Destroy(GameObject.FindWithTag("Answer"));
            GameManager.AnswerCorrectly();
        }
        else
        {
            Debug.Log("Wrong!");
        }

    }


   
    
    public void SpawnQuestion()
    {

        var questionIndex = Random.Range(0, GDQuestionArray.Length);
        var answerIndex = questionIndex;
        
        
        while (FinishedQuestions[questionIndex] != null)
        {
            questionIndex = Random.Range(0, GDQuestionArray.Length);
        }
        ActivateQuestion(questionIndex);
        FinishedQuestions[questionIndex] = GDQuestionArray[questionIndex];
    }

    public void SelectAnInputField(int fieldIndex)
    {
        MainInputField = MainInputFields[fieldIndex];
    }

    
    public void ActivateQuestion(int index)
    {
        if (!GDQuestionArray[index].activeInHierarchy)
        {
            GDQuestionArray[index].SetActive(true);
        }
        else
        {
            GDQuestionArray[index].SetActive(false);
        }

        
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
