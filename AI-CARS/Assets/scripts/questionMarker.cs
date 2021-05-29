using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questionMarker : MonoBehaviour
{
    public int no = 0;
    private quiz test;
    void Start()
    {
        test = GameObject.Find("test").GetComponent<quiz>();
        no = int.Parse(gameObject.name);
        gameObject.GetComponent<Button>().onClick.AddListener(clickQuestionMarker);
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
}
