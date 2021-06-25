using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questionMarker : MonoBehaviour
{
    public int no = 0;
    private quiz test;
    private exam test_exam;
    void Start()
    {
        if(GameObject.Find("test").GetComponent<quiz>())
        {
            test = GameObject.Find("test").GetComponent<quiz>();
            no = int.Parse(gameObject.name);
            gameObject.GetComponent<Button>().onClick.AddListener(clickQuestionMarker);
        }
       else
        {
            test_exam = GameObject.Find("test").GetComponent<exam>();
            no = int.Parse(gameObject.name);
            gameObject.GetComponent<Button>().onClick.AddListener(clickQuestionMarker_EXAM);
        }
        
    }
    void clickQuestionMarker()
    {
        test.GetComponent<quiz>().currentQuestion = no;
        test.GetComponent<quiz>().clear();
        if (test.GetComponent<quiz>().answersList[no] != "")
        {
            test.GetComponent<quiz>().setPreviousAnswer();
        }
    }
    void clickQuestionMarker_EXAM()
    {
        test_exam.GetComponent<exam>().currentQuestion = no;
        test_exam.GetComponent<exam>().clear();
        if (test_exam.GetComponent<exam>().answersList[no] != "")
        {
            test_exam.GetComponent<exam>().setPreviousAnswer();
        }
    }
}
