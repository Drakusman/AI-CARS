using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class cameraMovment : MonoBehaviour
{
    public float move_speed = 40f;
    public float scroll_speed = 5f;
    Ray ray;
    RaycastHit hit;
    public GameObject button_speed2, button_speed1, button_pause;
    private void Start()
    {
        button_speed2.GetComponent<Button>().onClick.AddListener(speed2);
        button_speed1.GetComponent<Button>().onClick.AddListener(speed1);
        button_pause.GetComponent<Button>().onClick.AddListener(pause);
    }
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out hit) && hit.transform.gameObject.tag == "player")
        {
            Selection.activeObject = hit.transform.gameObject;
        }
        if(Input.GetMouseButtonDown(1))
        {
            Selection.activeObject = null;
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
}
