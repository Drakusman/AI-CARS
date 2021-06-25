using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class quiz : MonoBehaviour
{
    [Header("Main objects")]
    public GameObject main_panel;
    public GameObject scroll_panel;
    public GameObject review_panel;
    //content = placeholder for questionMarkers
    public GameObject content;


    [Header("Answer buttons")]
    public GameObject button_ansA;
    public GameObject ansA_text;
    public GameObject button_ansB;
    public GameObject ansB_text;
    public GameObject button_ansC;
    public GameObject ansC_text;
    public GameObject button_ansD;
    public GameObject ansD_text;
    public GameObject img;
    public GameObject question;
    public GameObject checkAnswerText;
    public GameObject question_number;

    [Header("Navigation buttons")]
    public GameObject button_next;
    public GameObject button_previous;
    public GameObject button_checkAnswer;
    public GameObject button_exit;
    public GameObject button_review;

    [Header("Review_objects")]
    public GameObject answered_questions;
    public GameObject correct_questions;
    public GameObject percent_questions;
    public GameObject bank_questions;
    public GameObject button_review_back;
    public GameObject button_review_bank;

    [Header("Bank_objects")]
    public GameObject button_bank_back;
    public bool main_bank = false;

    [Header("Color settings")]
    public Color32 selection;
    public Color32 baseColor;
    public Color32 marker_color;
    public Color32 incorrect;

    public int currentQuestion = 0;
    public List<string> answersList = new List<string>();
    public List<string> answersList_review = new List<string>();

    //###########       MAIN PANEL
    // list of all question markers (on left) -> Main Panel
    public List<GameObject> allMarkers = new List<GameObject>();
    public List<Question> all_questions = new List<Question>();

    //###########       Review PANEL
    public List<Question> all_questions_Review = new List<Question>();
    public bool process_bank = false;

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
        button_exit.GetComponent<Button>().onClick.AddListener(button_exit_click);
        button_review.GetComponent<Button>().onClick.AddListener(button_review_click);

        //add listeners to review buttons
        button_review_back.GetComponent<Button>().onClick.AddListener(button_review_back_click);
        button_review_bank.GetComponent<Button>().onClick.AddListener(button_review_bank_click);

        //add listeners to bank buttons
        button_bank_back.GetComponent<Button>().onClick.AddListener(button_bank_back_click);

        //instantiate buttons markers on left
        for (int i = 0; i < all_questions.Count; i++)
        {
            GameObject newMarker = Instantiate(Resources.Load("UI/button_question")) as GameObject;
            newMarker.GetComponentInChildren<TextMeshProUGUI>().text = (i + 1).ToString();
            newMarker.name = (i).ToString();
            newMarker.transform.SetParent(content.transform);
            newMarker.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            allMarkers.Add(newMarker);
        }

        hide_review();
        hideCheckAnswer();
        show_main();

    }
    void Update()
    {
        if (!main_bank)
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
                img.SetActive(true);
                img.GetComponent<Image>().sprite = all_questions[currentQuestion].sprite;
            }
            else
            {
                img.SetActive(false);
                img.GetComponent<Image>().sprite = null;
            }
            //change questions by arrows /WSAD
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                nextQuestion();
            }
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                previousQuestion();
            }
            //check deselection
            if (Input.GetMouseButtonDown(1))
            {
                if (!main_bank)
                {
                    clear();
                    answersList[currentQuestion] = "";
                }

            }

            //set question numbers
            question_number.GetComponent<TextMeshProUGUI>().text = currentQuestion + 1 + "/" + all_questions.Count;

            update_question_markers();
        }
        else
        {
            //load all data into scene view
            question.GetComponent<Text>().text = all_questions_Review[currentQuestion].question;
            ansA_text.GetComponent<Text>().text = all_questions_Review[currentQuestion].ansA;
            ansB_text.GetComponent<Text>().text = all_questions_Review[currentQuestion].ansB;
            ansC_text.GetComponent<Text>().text = all_questions_Review[currentQuestion].ansC;
            ansD_text.GetComponent<Text>().text = all_questions_Review[currentQuestion].ansD;

            //load image/video/empty into scene view
            if (all_questions_Review[currentQuestion].sprite != null)
            {
                img.SetActive(true);
                img.GetComponent<Image>().sprite = all_questions_Review[currentQuestion].sprite;
            }
            else
            {
                img.SetActive(false);
                img.GetComponent<Image>().sprite = null;
            }
            //change questions by arrows /WSAD
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                nextQuestion();
            }
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                previousQuestion();
            }
            //check deselection
            if (Input.GetMouseButtonDown(1))
            {
                if (!main_bank)
                {
                    clear();
                    answersList[currentQuestion] = "";
                }

            }

            //set question numbers
            question_number.GetComponent<TextMeshProUGUI>().text = currentQuestion + 1 + "/" + all_questions_Review.Count;

            update_question_markers();
        }

    }

    #region Review
    void button_review_bank_click()
    {
        hide_review();
        hide_main();
        show_bank();
    }
    void button_review_back_click()
    {
        SceneManager.LoadScene(1);
    }
    void set_up_review_information()
    {
        //check answered questions and set up amount
        int counter = 0;
        for (int i = 0; i < answersList.Count; i++)
        {
            if (answersList[i] != "")
            {
                counter++;
            }
        }
        answered_questions.GetComponent<TextMeshProUGUI>().text = "Answered questions: " + counter + "/" + answersList.Count;

        //check correct question and set up amount

        int counter1 = 0;
        for (int i = 0; i < answersList.Count; i++)
        {
            if (answersList[i] == all_questions[i].correctAns)
            {
                counter1++;
            }
        }

        correct_questions.GetComponent<TextMeshProUGUI>().text = "Correct: " + counter1 + "/" + counter;

        //set correct percent
        double percent;

        if (counter > 0)
        {
            percent = Math.Round(double.Parse(counter1.ToString()) / float.Parse(counter.ToString()) * 100);
        }
        else
        {
            percent = 0;
        }

        percent_questions.GetComponent<TextMeshProUGUI>().text = "Correct by percent: " + percent + "%";
        if (counter == 0)
        {
            bank_questions.GetComponent<TextMeshProUGUI>().text = "You didn't answer any questions!";
            process_bank = false;
        }
        else if (counter - counter1 == 0)
        {
            bank_questions.GetComponent<TextMeshProUGUI>().text = "Congratulation you answered all questions correct!";
            process_bank = false;
        }
        else
        {
            bank_questions.GetComponent<TextMeshProUGUI>().text = "Added " + (counter - counter1) + " questions to bank pool";
            process_bank = true;
        }

    }
    void add_question_to_review()
    {
        for (int i = 0; i < all_questions.Count; i++)
        {
            if (answersList[i] != "")
            {
                all_questions_Review.Add(all_questions[i]);
            }
        }
    }
    void clear_questin_to_review()
    {
        if (all_questions_Review.Count > 0)
        {
            all_questions_Review.Clear();
        }
    }
    void button_review_click()
    {
        hide_main();
        show_review();
        clear_questin_to_review();
        add_question_to_review();
        set_up_review_information();
    }
    void show_review()
    {
        review_panel.SetActive(true);
    }

    void hide_review()
    {
        review_panel.SetActive(false);
    }
    #endregion
    #region Main
    void show_main()
    {
        if (!main_bank)
        {
            button_ansA.GetComponent<Button>().onClick.AddListener(selectA);
            button_ansB.GetComponent<Button>().onClick.AddListener(selectB);
            button_ansC.GetComponent<Button>().onClick.AddListener(selectC);
            button_ansD.GetComponent<Button>().onClick.AddListener(selectD);
            //load all question from database
            all_questions = GameObject.Find("admin").GetComponent<questions_database>().all_questions;
            if (allMarkers.Count > 0)
            {
                foreach (Transform item in content.transform)
                {
                    Destroy(item.gameObject);
                }
            }
            allMarkers.Clear();
            all_questions_Review.Clear();
            for (int i = 0; i < all_questions.Count; i++)
            {
                GameObject newMarker = Instantiate(Resources.Load("UI/button_question")) as GameObject;
                newMarker.GetComponentInChildren<TextMeshProUGUI>().text = (i + 1).ToString();
                newMarker.name = (i).ToString();
                newMarker.transform.SetParent(content.transform);
                newMarker.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                allMarkers.Add(newMarker);
            }
            answersList.Clear();
            answersList_review.Clear();
            for (int i = 0; i < all_questions.Count; i++)
            {
                answersList.Add("");
            }
            button_checkAnswer.SetActive(true);
            button_exit.SetActive(true);
            button_review.SetActive(true);
            button_bank_back.SetActive(false);
            update_question_markers();
        }


        main_panel.SetActive(true);
        scroll_panel.SetActive(true);

    }
    void hide_main()
    {
        main_panel.SetActive(false);
        scroll_panel.SetActive(false);
    }
    void update_question_markers()
    {
        for (int i = 0; i < answersList.Count; i++)
        {
            if (answersList[i] != "")
            {
                if (allMarkers[i] != null)
                    allMarkers[i].GetComponent<Image>().color = marker_color;
            }
            else
            {
                if (allMarkers[i] != null)
                    allMarkers[i].GetComponent<Image>().color = baseColor;
            }
        }
    }
    void button_exit_click()
    {
        login_system.currentUser = static_buffor.memo_user;
        SceneManager.LoadScene(0);
    }
    void selectA()
    {

        if (!main_bank)
        {
            clear();
            button_ansA.GetComponent<Image>().color = selection;
            answersList[currentQuestion] = "A";
        }
        else
        {
            button_ansA.GetComponent<Image>().color = incorrect;
        }

    }
    void selectB()
    {

        if (!main_bank)
        {
            clear();
            button_ansB.GetComponent<Image>().color = selection;
            answersList[currentQuestion] = "B";
        }
        else
        {
            button_ansB.GetComponent<Image>().color = incorrect;
        }

    }
    void selectC()
    {

        if (!main_bank)
        {
            clear();
            button_ansC.GetComponent<Image>().color = selection;
            answersList[currentQuestion] = "C";
        }
        else
        {
            button_ansC.GetComponent<Image>().color = incorrect;
        }

    }
    void selectD()
    {

        if (!main_bank)
        {
            clear();
            button_ansD.GetComponent<Image>().color = selection;
            answersList[currentQuestion] = "D";
        }
        else
        {
            button_ansD.GetComponent<Image>().color = incorrect;
        }

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


        if (!main_bank)
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
        else
        {
            if (currentQuestion < all_questions_Review.Count - 1)
            {
                currentQuestion++;
                clear();
                switch (answersList_review[currentQuestion])
                {
                    case "A":
                        {
                            button_ansA.GetComponent<Image>().color = incorrect;
                            break;
                        }
                    case "B":
                        {
                            button_ansB.GetComponent<Image>().color = incorrect;
                            break;
                        }
                    case "C":
                        {
                            button_ansC.GetComponent<Image>().color = incorrect;
                            break;
                        }
                    case "D":
                        {
                            button_ansD.GetComponent<Image>().color = incorrect;
                            break;
                        }
                }
                switch (all_questions_Review[currentQuestion].correctAns)
                {
                    case "A":
                        {
                            button_ansA.GetComponent<Image>().color = selection;
                            break;
                        }
                    case "B":
                        {
                            button_ansB.GetComponent<Image>().color = selection;
                            break;
                        }
                    case "C":
                        {
                            button_ansC.GetComponent<Image>().color = selection;
                            break;
                        }
                    case "D":
                        {
                            button_ansD.GetComponent<Image>().color = selection;
                            break;
                        }
                }
            }

        }



    }
    public void setPreviousAnswer()
    {
        if (!main_bank)
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

    }
    void previousQuestion()
    {
        if (!main_bank)
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
        else
        {
            if (currentQuestion > 0)
            {
                currentQuestion--;
                clear();
                switch (answersList_review[currentQuestion])
                {
                    case "A":
                        {
                            button_ansA.GetComponent<Image>().color = incorrect;
                            break;
                        }
                    case "B":
                        {
                            button_ansB.GetComponent<Image>().color = incorrect;
                            break;
                        }
                    case "C":
                        {
                            button_ansC.GetComponent<Image>().color = incorrect;
                            break;
                        }
                    case "D":
                        {
                            button_ansD.GetComponent<Image>().color = incorrect;
                            break;
                        }
                }
                switch (all_questions_Review[currentQuestion].correctAns)
                {
                    case "A":
                        {
                            button_ansA.GetComponent<Image>().color = selection;
                            break;
                        }
                    case "B":
                        {
                            button_ansB.GetComponent<Image>().color = selection;
                            break;
                        }
                    case "C":
                        {
                            button_ansC.GetComponent<Image>().color = selection;
                            break;
                        }
                    case "D":
                        {
                            button_ansD.GetComponent<Image>().color = selection;
                            break;
                        }
                }
            }
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
    #endregion
    #region Bank
    void button_bank_back_click()
    {
        SceneManager.LoadScene(1);
    }
    void show_bank()
    {
        if(process_bank)
        {
            button_ansA.GetComponent<Button>().onClick.RemoveAllListeners();
            button_ansB.GetComponent<Button>().onClick.RemoveAllListeners();
            button_ansC.GetComponent<Button>().onClick.RemoveAllListeners();
            button_ansD.GetComponent<Button>().onClick.RemoveAllListeners();
            main_bank = true;

            foreach (Transform item in content.transform)
            {
                Destroy(item.gameObject);
            }
            allMarkers.Clear();
            all_questions_Review.Clear();
            for (int i = 0; i < answersList.Count; i++)
            {
                if (answersList[i] != "" && answersList[i] != all_questions[i].correctAns)
                {
                    all_questions_Review.Add(all_questions[i]);
                    answersList_review.Add(answersList[i]);
                }
            }
            answersList = answersList_review;
            button_exit.SetActive(false);
            button_review.SetActive(false);
            button_checkAnswer.SetActive(false);

            load_newMarkers_into_bank();

            button_bank_back.SetActive(true);

            currentQuestion = 1;

            hide_review();
            //change question no from 1 to 0 and reset value of marked questions
            previousQuestion();
            show_main();
        }
        else
        {
            hide_review();
            show_main();
            SceneManager.LoadScene(1);
        }
       
    }
    void hide_bank()
    {
        clear_questin_to_review();
        main_bank = false;
        show_main();
    }
    void load_newMarkers_into_bank()
    {
        for (int i = 0; i < all_questions_Review.Count; i++)
        {
            GameObject newMarker = Instantiate(Resources.Load("UI/button_question")) as GameObject;
            newMarker.GetComponentInChildren<TextMeshProUGUI>().text = (i + 1).ToString();
            newMarker.name = (i).ToString();
            newMarker.transform.SetParent(content.transform);
            newMarker.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            allMarkers.Add(newMarker);
        }
    }
    #endregion
}
[Serializable]
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
