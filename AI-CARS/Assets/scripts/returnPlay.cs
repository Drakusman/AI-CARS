using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class returnPlay : MonoBehaviour
{
    public GameObject button_exit_play;
    void Start()
    {
        button_exit_play.GetComponent<Button>().onClick.AddListener(button_exit_play_click);
    }

    void button_exit_play_click()
    {
        login_system.currentUser = static_buffor.memo_user;
        SceneManager.LoadScene(0);
    }
}
