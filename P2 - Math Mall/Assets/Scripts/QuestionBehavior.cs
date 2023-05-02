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
    public GameObject[] GDFinishedQuestions = new GameObject[10];
    [SerializeField]
    public GameObject[] GeoQuestionArray;
    public GameObject[] GeoFinishedQuestions = new GameObject[10];


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

    public void SpawnGDQuestion()
    {
        SpawnTheQuestion(GDQuestionArray,GDFinishedQuestions);
    }

    public void SpawnGeoQuestion()
    {
        SpawnTheQuestion(GeoQuestionArray,GeoFinishedQuestions);
    }

    
    public void SpawnTheQuestion(GameObject[] array, GameObject[] finishedQuestions)
    {

        var questionIndex = Random.Range(0, array.Length);
        var answerIndex = questionIndex;
        
        
        while (finishedQuestions[questionIndex] != null)
        {
            questionIndex = Random.Range(0, array.Length);
        }
        array[questionIndex].SetActive(true);
        finishedQuestions[questionIndex] = array[questionIndex];
    }


    public void SelectAnInputField(int fieldIndex)
    {
        MainInputField = MainInputFields[fieldIndex];
    }

    
    public void ActivateQuestion(int index)
    {
        if (!GDQuestionArray[index].activeInHierarchy || !GeoQuestionArray[index].activeInHierarchy)
        {
            GameObject.FindGameObjectWithTag("Question").SetActive(true);
        }
        else
        {
            GameObject.FindGameObjectWithTag("Question").SetActive(true);
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
