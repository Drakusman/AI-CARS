using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class exam : MonoBehaviour
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
    public GameObject question_number;
    public GameObject timer;

    [Header("Navigation buttons")]
    public GameObject button_next;
    public GameObject button_previous;
    public GameObject button_exit;
    public GameObject button_review;

    [Header("Review_objects")]
    public GameObject answered_questions;
    public GameObject correct_questions;
    public GameObject percent_questions;
    public GameObject button_review_back;
    public GameObject information;

    [Header("Color settings")]
    public Color32 selection;
    public Color32 baseColor;
    public Color32 marker_color;

    public int currentQuestion = 0;
    public List<string> answersList = new List<string>();
    public List<string> answersList_review = new List<string>();

    //###########       MAIN PANEL
    // list of all question markers (on left) -> Main Panel
    public List<GameObject> allMarkers = new List<GameObject>();
    public List<Question> all_questions = new List<Question>();

    float time = 0f;
    TimeSpan total_time;
    //###########       Review PANEL
    public List<Question> all_questions_Review = new List<Question>();

    private void Start()
    {
        //load all question from database
        random_question_set();
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
        button_exit.GetComponent<Button>().onClick.AddListener(button_exit_click);
        button_review.GetComponent<Button>().onClick.AddListener(button_review_click);

        //add listeners to review buttons
        button_review_back.GetComponent<Button>().onClick.AddListener(button_review_back_click);

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
        show_main();

    }
    void Update()
    {
        //time counter
        time += Time.deltaTime;
        total_time = TimeSpan.FromSeconds(Math.Floor(time));

        timer.GetComponent<TextMeshProUGUI>().text = string.Format("{0} min {1} sec",total_time.Minutes,total_time.Seconds);
        //stop exam when time passed 57min...
        if(total_time.Minutes>=57)
        {
            button_review_click();
        }

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

            clear();
            answersList[currentQuestion] = "";


        }

        //set question numbers
        question_number.GetComponent<TextMeshProUGUI>().text = currentQuestion + 1 + "/" + all_questions.Count;

        update_question_markers();


    }

    #region Review
    void button_review_back_click()
    {
        login_system.currentUser = static_buffor.memo_user;
        SceneManager.LoadScene(0);
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
        if (counter1 >= 43)
        {
            information.GetComponent<TextMeshProUGUI>().text = "Congratulations you passed the exam!";
        }
        else
        {
            information.GetComponent<TextMeshProUGUI>().text = "Unfortunately you didin't pass the exam!";
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
        all_questions_Review.Clear();
       
        answersList.Clear();
        answersList_review.Clear();
        for (int i = 0; i < all_questions.Count; i++)
        {
            answersList.Add("");
        }
        button_exit.SetActive(true);
        button_review.SetActive(true);

        update_question_markers();

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
                
                    allMarkers[i].GetComponent<Image>().color = marker_color;
            }
            else
            {
                
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
   
    #endregion
    void random_question_set()
    {
        all_questions.Clear();
        all_questions = new List<Question>();
        List<int> question_no = new List<int>();

        print(GameObject.Find("admin").GetComponent<questions_database>().all_questions.Count);
        for (int i = 0; i < 50; i++)
        {
            int number = UnityEngine.Random.Range(0, GameObject.Find("admin").GetComponent<questions_database>().all_questions.Count);
            if (!question_no.Contains(number))
            {
                question_no.Add(number);
                all_questions.Add(GameObject.Find("admin").GetComponent<questions_database>().all_questions[number]);
            }
            else
            {
                i--;
            }
            
        }
    }
}


