using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class tasks : MonoBehaviour
{
    //place holder for task information
    public GameObject task_info;

    public bool onTask = false;
    public bool task_checkpoint = false;
    public bool task_parking = false;

    private GameObject checkpoint;
    private List<Transform> all_spawns;
    public GameObject current_task;
    public List<GameObject> garageList;
    void Start()
    {
        task_info = GameObject.Find("task_info");
        checkpoint = Resources.Load<GameObject>("checkpoint");
        all_spawns = gameObject.GetComponent<admin>().all_spawn_points;
        garageList = new List<GameObject>(GameObject.FindGameObjectsWithTag("garage"));
    }

    void Update()
    {
        if (task_checkpoint)
        {
            task_info.GetComponent<TextMeshProUGUI>().text = "Reach point!";
        }
        if (task_parking)
        {
            task_info.GetComponent<TextMeshProUGUI>().text = "Park on specific point!";
        }
        if (onTask == false)
        {
            int random;
            if (garageList.Count > 0)
            {
                random = Random.Range(1, 3);
            }
            else
            {
                random = 1;
            }


            if (random == 1)
            {
                generateTask_checkpoint();
            }
            else if (random == 2)
            {
                generateTask_parking();
            }

        }
    }
    public void generateTask_checkpoint()
    {
        int random = Random.Range(0, all_spawns.Count - 1);
        GameObject check = Instantiate(checkpoint, all_spawns[random].position, checkpoint.transform.rotation);
        Vector3 newPossition = new Vector3(check.transform.position.x, check.transform.position.y - 3f, check.transform.position.z);
        check.transform.position = newPossition;
        current_task = check;
        onTask = true;
        task_checkpoint = true;
    }
    public void generateTask_parking()
    {
        int random = Random.Range(0, garageList.Count - 1);
        GameObject check = Instantiate(checkpoint, garageList[random].transform.position, checkpoint.transform.rotation);
        current_task = check;
        onTask = true;
        task_parking = true;
    }
}
