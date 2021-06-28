using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    public GameObject arrow_gameobject;
    public GameObject player;
    Vector3 position;


    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("player")[0];
        position = player.transform.position;
        arrow_gameobject = Instantiate(Resources.Load<GameObject>("structure/prefabs/arrow"), position, Quaternion.identity) as GameObject;
    }

    void Update()
    {
        position = player.transform.position;
        position.y += 3.5f;
        //check if there is active task! set localisation of current gameobject of task type
        if(GameObject.Find("admin").GetComponent<tasks>().current_task!=null)
        {
            GameObject task = GameObject.Find("admin").GetComponent<tasks>().current_task;
            arrow_gameobject.transform.LookAt(task.transform);
            arrow_gameobject.transform.position = position;
        }
        
    }
}
