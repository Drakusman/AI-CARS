using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class quiz : MonoBehaviour
{
    public GameObject button_ansA, ansA_text, button_ansB, ansB_text, button_ansC, ansC_text, button_ansD, ansD_text, img, question, checkAnswerText;
    public GameObject button_next, button_previous, button_checkAnswer, button_exit;
    //content = placeholder for questionMarkers
    public GameObject content;
    public Color32 selection;
    public Color32 baseColor;
    public int currentQuestion = 0;
    public List<string> answersList = new List<string>();
    private List<Question> all_questions = new List<Question>();

    private void Start()
    {
        //load all question from database
        all_questions = GameObject.Find("admin").GetComponent<questions_database>().all_questions;
        //set up empty answer list
        for (int i = 0; i < all_questions.Count; i++)
        {
            answersList.Add("");
        }
        //add listeners to answer buttons
        button_ansA.GetComponent<Button>().onClick.AddListener(selectA);
        button_ansB.GetComponent<Button>().onClick.AddListener(selectB);
        button_ansC.GetComponent<Button>().onClick.AddListener(selectC);
        button_ansD.GetComponent<Button>().onClick.AddListener(selectD);

        //add listeners to navigation buttons
        button_next.GetComponent<Button>().onClick.AddListener(nextQuestion);
        button_previous.GetComponent<Button>().onClick.AddListener(previousQuestion);
        button_checkAnswer.GetComponent<Button>().onClick.AddListener(correctCheck);

        //instantiate buttons markers on left
        for (int i = 0; i < all_questions.Count; i++)
        {
            GameObject newMarker = Instantiate(Resources.Load("UI/button_question")) as GameObject;
            newMarker.GetComponentInChildren<TextMeshProUGUI>().text = (i + 1).ToString();
            newMarker.name = (i).ToString();
            newMarker.transform.SetParent(content.transform);
            newMarker.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }

        hideCheckAnswer();

    }
    void Update()
    {
        //load all data into scene view
        question.GetComponent<Text>().text = all_questions[currentQuestion].question;
        ansA_text.GetComponent<Text>().text = all_questions[currentQuestion].ansA;
        ansB_text.GetComponent<Text>().text = all_questions[currentQuestion].ansB;
        ansC_text.GetComponent<Text>().text = all_questions[currentQuestion].ansC;
        ansD_text.GetComponent<Text>().text = all_questions[currentQuestion].ansD;

        //load image/video/empty into scene view
        if (all_questions[currentQuestion].sprite != null)
        {
            img.GetComponent<Image>().sprite = all_questions[currentQuestion].sprite;
        }
        else
        {
            img.GetComponent<Image>().sprite = null;
        }
    }
    void selectA()
    {
        clear();
        button_ansA.GetComponent<Image>().color = selection;
        answersList[currentQuestion] = "A";
    }
    void selectB()
    {
        clear();
        button_ansB.GetComponent<Image>().color = selection;
        answersList[currentQuestion] = "B";
    }
    void selectC()
    {
        clear();
        button_ansC.GetComponent<Image>().color = selection;
        answersList[currentQuestion] = "C";
    }
    void selectD()
    {
        clear();
        button_ansD.GetComponent<Image>().color = selection;
        answersList[currentQuestion] = "D";
    }
    public void clear()
    {
        hideCheckAnswer();
        button_ansA.GetComponent<Image>().color = baseColor;
        button_ansB.GetComponent<Image>().color = baseColor;
        button_ansC.GetComponent<Image>().color = baseColor;
        button_ansD.GetComponent<Image>().color = baseColor;
    }
    void nextQuestion()
    {
        clear();
        if (currentQuestion < all_questions.Count - 1)
        {
            currentQuestion++;
        }
        if (answersList[currentQuestion] != "")
        {
            setPreviousAnswer();
        }

    }
    public void setPreviousAnswer()
    {
        switch (answersList[currentQuestion])
        {
            case "A":
                {
                    selectA();
                    break;
                }
            case "B":
                {
                    selectB();
                    break;
                }
            case "C":
                {
                    selectC();
                    break;
                }
            case "D":
                {
                    selectD();
                    break;
                }
        }
    }
    void previousQuestion()
    {
        clear();
        if (currentQuestion > 0)
        {
            currentQuestion--;
        }
        if (answersList[currentQuestion] != "")
        {
            setPreviousAnswer();
        }
    }
    void correctCheck()
    {
        showCheckAnswer();
        if (answersList[currentQuestion] == all_questions[currentQuestion].correctAns)
        {
            checkAnswerText.GetComponent<Text>().color = Color.green;
            checkAnswerText.GetComponent<Text>().text = "Correct";
        }
        else
        {
            checkAnswerText.GetComponent<Text>().color = Color.red;
            checkAnswerText.GetComponent<Text>().text = "Incorrect";
        }
    }
    void hideCheckAnswer()
    {
        checkAnswerText.SetActive(false);
    }
    void showCheckAnswer()
    {
        checkAnswerText.SetActive(true);
    }
}
public class Question
{
    public string question;
    public string ansA;
    public string ansB;
    public string ansC;
    public string ansD;
    public string correctAns;
    public int points;
    public Sprite sprite;

    public Question(string question, string ansA, string ansB, string ansC, string ansD, string correctAns, int points, Sprite sprite)
    {
        this.question = question;
        this.ansA = ansA;
        this.ansB = ansB;
        this.ansC = ansC;
        this.ansD = ansD;
        this.correctAns = correctAns;
        this.points = points;
        this.sprite = sprite;
    }

    public Question()
    {
        this.question = "none";
        this.ansA = "none";
        this.ansB = "none";
        this.ansC = "none";
        this.ansD = "none";
        this.correctAns = "none";
        this.points = 0;
        this.sprite = null;
    }
}
