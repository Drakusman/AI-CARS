using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif


public class cameraMovment : MonoBehaviour
{
    public float move_speed = 40f;
    public float scroll_speed = 5f;
    Ray ray;
    RaycastHit hit;
    public GameObject button_speed2, button_speed1, button_pause, button_end;
    private void Start()
    {
        button_speed2.GetComponent<Button>().onClick.AddListener(speed2);
        button_speed1.GetComponent<Button>().onClick.AddListener(speed1);
        button_pause.GetComponent<Button>().onClick.AddListener(pause);
        button_end.GetComponent<Button>().onClick.AddListener(end);
    }
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);



        if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out hit) && hit.transform.gameObject.tag == "player")
        {
#if UNITY_EDITOR
            Selection.activeObject = hit.transform.gameObject;
#endif
        }
        if (Input.GetMouseButtonDown(1))
        {
#if UNITY_EDITOR
            Selection.activeObject = null;
#endif
        }
        if (Input.GetMouseButton(2))
        {
            Vector3 position = new Vector3(Input.GetAxis("Mouse X"), 0f, Input.GetAxis("Mouse Y"));
            Vector3 new_position = Camera.main.transform.position - (position * move_speed * Time.deltaTime);
            Camera.main.transform.position = new_position;
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            Vector3 new_position = Camera.main.transform.position;
            new_position.y -= scroll_speed;
            Camera.main.transform.position = new_position;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            Vector3 new_position = Camera.main.transform.position;
            new_position.y += scroll_speed;
            Camera.main.transform.position = new_position;
        }

    }
    public void speed2()
    {
        Time.timeScale = 2;
    }
    public void speed1()
    {
        Time.timeScale = 1;
    }
    public void pause()
    {
        Time.timeScale = 0;
    }
    public void end()
    {
        login_system.currentUser = static_buffor.memo_user;
        SceneManager.LoadScene(0);
    }
}
