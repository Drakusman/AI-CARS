using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{
    public GameObject title;

    [Header("Login")]
    public GameObject login;
    public GameObject login_button;
    public GameObject create_button;
    public GameObject exit_button_login;

    [Header("Login Input")]
    public GameObject login_input;
    public GameObject email_input_login;
    public GameObject password_input_login;
    public GameObject enter_button;
    public GameObject message_text_input_login;
    public GameObject back_button_input_login;

    [Header("Sign Up")]
    public GameObject signUp;
    public GameObject name_input_signup;
    public GameObject surname_input_signup;
    public GameObject email_input_signup;
    public GameObject password1_input_signup;
    public GameObject password2_input_signup;
    public GameObject gender_input_signup;
    public GameObject age_input_signup;
    public GameObject signUp_button;
    public GameObject message_signup;
    public GameObject back_signup;

    [Header("User Menu")]
    public GameObject userMenu;
    public GameObject player_test_button;
    public GameObject ai_test_button;
    public GameObject settings_button;
    public GameObject exit_button_menu;
    public GameObject logout_button_menu;
    public GameObject welcome_text_menu;

    [Header("Player")]
    public GameObject player;
    public GameObject drive_button_player;
    public GameObject theory_button_player;
    public GameObject progress_button_player;
    public GameObject back_button_player;

    [Header("Drive")]
    public GameObject drive;
    public GameObject a;

    [Header("Theory")]
    public GameObject theory;
    public GameObject practise_button;
    public GameObject exam_button;
    public GameObject theory_button_back;

    [Header("Progress")]
    public GameObject progress;
    public GameObject c;

    [Header("AI Test")]
    public GameObject aiTest;
    public GameObject path;
    public GameObject collision;
    public GameObject traffic;
    public GameObject back_AI;

    [Header("Settings")]
    public GameObject settings;
    public GameObject settings_back_button;
    void Start()
    {
        #region login
        login_button.GetComponent<Button>().onClick.AddListener(login_click);
        create_button.GetComponent<Button>().onClick.AddListener(create_click);
        exit_button_login.GetComponent<Button>().onClick.AddListener(exit_click);
        #endregion

        #region login_input
        enter_button.GetComponent<Button>().onClick.AddListener(try_login_input);
        back_button_input_login.GetComponent<Button>().onClick.AddListener(back_login_input_click);
        #endregion

        #region user_menu
        player_test_button.GetComponent<Button>().onClick.AddListener(player_test_click);
        ai_test_button.GetComponent<Button>().onClick.AddListener(ai_test_click);
        settings_button.GetComponent<Button>().onClick.AddListener(settings_click);
        exit_button_menu.GetComponent<Button>().onClick.AddListener(exit_click);
        logout_button_menu.GetComponent<Button>().onClick.AddListener(logout_button_menu_click);
        #endregion

        #region signUp
        signUp_button.GetComponent<Button>().onClick.AddListener(signUp_click);
        back_signup.GetComponent<Button>().onClick.AddListener(back_signup_click);
        #endregion;

        #region player
        theory_button_player.GetComponent<Button>().onClick.AddListener(start_theory);
        back_button_player.GetComponent<Button>().onClick.AddListener(back_player_click);
        #endregion

        #region settings
        settings_back_button.GetComponent<Button>().onClick.AddListener(settings_back_click);
        #endregion

        #region AI_test
        back_AI.GetComponent<Button>().onClick.AddListener(back_AI_test_click);
        path.GetComponent<Button>().onClick.AddListener(ai_test_path_click);
        collision.GetComponent<Button>().onClick.AddListener(ai_test_collision_click);
        traffic.GetComponent<Button>().onClick.AddListener(ai_test_traffic_click);
        #endregion

        #region Theory
        practise_button.GetComponent<Button>().onClick.AddListener(practise_button_click);
        exam_button.GetComponent<Button>().onClick.AddListener(exam_button_click);
        theory_button_back.GetComponent<Button>().onClick.AddListener(theory_button_back_click);
        #endregion
        //load previous user!!
        if (login_system.currentUser != null)
        {
            hide_all();
            welcome_text_menu.GetComponent<TextMeshProUGUI>().text = "Welcome " + login_system.currentUser.email;
            show_main_menu();
        }

        //if there is no loading back go normal modehej

    }
    #region login
    void show_login()
    {
        login.SetActive(true);
        login_button.SetActive(true);
        create_button.SetActive(true);
        exit_button_login.SetActive(true);
    }
    void hide_login()
    {
        login.SetActive(false);
        login_button.SetActive(false);
        create_button.SetActive(false);
        exit_button_login.SetActive(false);
    }
    void login_click()
    {
        hide_login();

        message_text_input_login.GetComponent<TextMeshProUGUI>().text = "";
        show_login_input();
    }
    void create_click()
    {
        hide_login();

        message_signup.GetComponent<TextMeshProUGUI>().text = "";
        show_signUp();
    }
    #endregion

    #region Login_input
    void show_login_input()
    {
        login_input.SetActive(true);
        email_input_login.SetActive(true);
        password_input_login.SetActive(true);
        enter_button.SetActive(true);
        message_text_input_login.SetActive(true);
        back_button_input_login.SetActive(true);
    }
    void hide_login_input()
    {
        login_input.SetActive(false);
        email_input_login.SetActive(false);
        password_input_login.SetActive(false);
        enter_button.SetActive(false);
        message_text_input_login.SetActive(false);
        back_button_input_login.SetActive(false);
    }
    void back_login_input_click()
    {
        clear_login_input();
        hide_login_input();
        show_login();
    }
    void clear_login_input()
    {
        email_input_login.GetComponent<TMP_InputField>().text = "";
        password_input_login.GetComponent<TMP_InputField>().text = "";
    }
    void try_login_input()
    {
        string email = email_input_login.GetComponent<TMP_InputField>().text;

        string password = password_input_login.GetComponent<TMP_InputField>().text;

        if (email.Length > 0 && password.Length > 0)
        {
            if (gameObject.GetComponent<login_system>().login(email, password))
            {
                //some action when login successfully!
                email_input_login.GetComponent<TMP_InputField>().text = "";
                password_input_login.GetComponent<TMP_InputField>().text = "";
                message_text_input_login.GetComponent<TextMeshProUGUI>().text = "";
                hide_login_input();
                welcome_text_menu.GetComponent<TextMeshProUGUI>().text = "Welcome " + login_system.currentUser.email;
                show_main_menu();
            }
            else
            {
                message_text_input_login.GetComponent<TextMeshProUGUI>().text = "Can't find user!";
            }
        }
        else
        {
            message_text_input_login.GetComponent<TextMeshProUGUI>().text = "Email and/or password can not be empty!";
        }
    }
    #endregion

    #region user_menu
    void show_main_menu()
    {
        userMenu.SetActive(true);
        player_test_button.SetActive(true);
        ai_test_button.SetActive(true);
        settings_button.SetActive(true);
        exit_button_menu.SetActive(true);
        welcome_text_menu.SetActive(true);
    }
    void hide_main_menu()
    {
        userMenu.SetActive(false);
        player_test_button.SetActive(false);
        ai_test_button.SetActive(false);
        settings_button.SetActive(false);
        exit_button_menu.SetActive(false);
        welcome_text_menu.SetActive(false);
    }
    void logout_button_menu_click()
    {
        gameObject.GetComponent<login_system>().logout();
        hide_main_menu();
        show_login();
    }
    void player_test_click()
    {
        hide_main_menu();
        show_player();
    }
    void settings_click()
    {
        hide_main_menu();
        show_settings();
    }
    void ai_test_click()
    {
        hide_main_menu();
        show_AI_test();
    }
    #endregion

    #region signUp
    void show_signUp()
    {
        signUp.SetActive(true);
        name_input_signup.SetActive(true);
        surname_input_signup.SetActive(true);
        email_input_signup.SetActive(true);
        password1_input_signup.SetActive(true);
        password2_input_signup.SetActive(true);
        gender_input_signup.SetActive(true);
        age_input_signup.SetActive(true);
        signUp_button.SetActive(true);
        message_signup.SetActive(true);
        back_signup.SetActive(true);
    }
    void hide_signUp()
    {
        signUp.SetActive(false);
        name_input_signup.SetActive(false);
        surname_input_signup.SetActive(false);
        email_input_signup.SetActive(false);
        password1_input_signup.SetActive(false);
        password2_input_signup.SetActive(false);
        gender_input_signup.SetActive(false);
        age_input_signup.SetActive(false);
        signUp_button.SetActive(false);
        message_signup.SetActive(false);
        back_signup.SetActive(false);
    }
    void back_signup_click()
    {
        clear_input_signUp();
        hide_signUp();
        show_login();
    }
    void clear_input_signUp()
    {
        name_input_signup.GetComponent<TMP_InputField>().text = "";
        surname_input_signup.GetComponent<TMP_InputField>().text = "";
        email_input_signup.GetComponent<TMP_InputField>().text = "";
        password1_input_signup.GetComponent<TMP_InputField>().text = "";
        password2_input_signup.GetComponent<TMP_InputField>().text = "";
        age_input_signup.GetComponent<TMP_InputField>().text = "";
        gender_input_signup.GetComponent<TMP_Dropdown>().value = 0;
    }
    //signUp procedure + correctness checks!
    void signUp_click()
    {
        //check if email and password aren't empty
        if (email_input_signup.GetComponent<TMP_InputField>().text.Length > 0 &&
            password1_input_signup.GetComponent<TMP_InputField>().text.Length > 0 &&
            password2_input_signup.GetComponent<TMP_InputField>().text.Length > 0)
        {
            //check if email is free
            if (gameObject.GetComponent<login_system>().checkEmail(email_input_signup.GetComponent<TMP_InputField>().text))
            {
                //check if passwords match
                if (password1_input_signup.GetComponent<TMP_InputField>().text == password2_input_signup.GetComponent<TMP_InputField>().text)
                {
                    int age;
                    //check if age is and decimal
                    if (int.TryParse(age_input_signup.GetComponent<TMP_InputField>().text, out age) || age_input_signup.GetComponent<TMP_InputField>().text.Length == 0)
                    {
                        User.Gender gender;
                        switch (gender_input_signup.GetComponent<TMP_Dropdown>().value)
                        {
                            case 0:
                                {
                                    gender = User.Gender.female;
                                    break;
                                }
                            case 1:
                                {
                                    gender = User.Gender.male;
                                    break;
                                }
                            case 2:
                                {
                                    gender = User.Gender.none;
                                    break;
                                }
                            default:
                                {
                                    gender = User.Gender.none;
                                    break;
                                }
                        }
                        //new User sign up!
                        User newUser = new User(
                        name_input_signup.GetComponent<TMP_InputField>().text,
                        surname_input_signup.GetComponent<TMP_InputField>().text,
                        email_input_signup.GetComponent<TMP_InputField>().text,
                        age,
                        gender);
                        //set up password
                        newUser.set_password(password1_input_signup.GetComponent<TMP_InputField>().text);

                        gameObject.GetComponent<login_system>().userList.Add(newUser);
                        gameObject.GetComponent<login_system>().saveUserList();

                        message_signup.GetComponent<TextMeshProUGUI>().text = "User: " + email_input_signup.GetComponent<TMP_InputField>().text + " successfully created!";

                        clear_input_signUp();

                    }
                    else
                    {
                        message_signup.GetComponent<TextMeshProUGUI>().text = "Age must be a decimal!";
                    }

                }
                else
                {
                    message_signup.GetComponent<TextMeshProUGUI>().text = "Sorry passwords dont match!";
                }
            }
            else
            {
                message_signup.GetComponent<TextMeshProUGUI>().text = "User with this email already exists!";
            }
        }
        else
        {
            message_signup.GetComponent<TextMeshProUGUI>().text = "Email and password are required!";
        }
    }
    #endregion;

    #region player
    void show_player()
    {
        player.SetActive(true);
        drive_button_player.SetActive(true);
        theory_button_player.SetActive(true);
        progress_button_player.SetActive(true);
        back_button_player.SetActive(true);
    }
    void hide_player()
    {
        player.SetActive(false);
        drive_button_player.SetActive(false);
        theory_button_player.SetActive(false);
        progress_button_player.SetActive(false);
        back_button_player.SetActive(false);
    }
    void start_theory()
    {
        hide_player();
        show_theory();
        static_buffor.memo_user = login_system.currentUser;
        
    }
    void back_player_click()
    {
        hide_player();
        show_main_menu();
    }
    #endregion

    #region settings
    void show_settings()
    {
        settings.SetActive(true);
        settings_back_button.SetActive(true);
    }
    void hide_settings()
    {
        settings.SetActive(false);
        settings_back_button.SetActive(false);
    }
    void settings_back_click()
    {
        hide_settings();
        show_main_menu();
    }
    #endregion

    #region AI_test
    void hide_AI_test()
    {
        aiTest.SetActive(false);
        path.SetActive(false);
        collision.SetActive(false);
        traffic.SetActive(false);
        back_AI.SetActive(false);
    }
    void show_AI_test()
    {
        aiTest.SetActive(true);
        path.SetActive(true);
        collision.SetActive(true);
        traffic.SetActive(true);
        back_AI.SetActive(true);
    }
    void back_AI_test_click()
    {
        hide_AI_test();
        show_main_menu();
    }
    void ai_test_path_click()
    {
        hide_AI_test();
        static_buffor.memo_user = login_system.currentUser;
        SceneManager.LoadScene(2);
    }
    void ai_test_collision_click()
    {
        hide_AI_test();
        static_buffor.memo_user = login_system.currentUser;
        //SceneManager.LoadScene(2);
    }
    void ai_test_traffic_click()
    {
        hide_AI_test();
        static_buffor.memo_user = login_system.currentUser;
        SceneManager.LoadScene(3);
    }
    #endregion

    #region Theory
    void show_theory()
    {
        theory.SetActive(true);
        practise_button.SetActive(true);
        exam_button.SetActive(true);
        theory_button_back.SetActive(true);
    }
    void hide_theory()
    {
        theory.SetActive(false);
        practise_button.SetActive(false);
        exam_button.SetActive(false);
        theory_button_back.SetActive(false);
    }
    void practise_button_click()
    {
        hide_theory();
        static_buffor.memo_user = login_system.currentUser;
        SceneManager.LoadScene(1);
    }
    void exam_button_click()
    {
        hide_theory();
        static_buffor.memo_user = login_system.currentUser;
        SceneManager.LoadScene(4);
    }
    void theory_button_back_click()
    {
        hide_theory();
        show_player();
    }
    #endregion
    void exit_click()
    {
        gameObject.GetComponent<login_system>().saveUserList();
        Debug.Log("Saving...Exiting...");
        Application.Quit();
    }
    private void hide_all()
    {
        hide_login();
        hide_login_input();
        hide_main_menu();
        hide_signUp();
        hide_settings();
    }
}
