﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class admin : MonoBehaviour
{
    public List<Transform> all_spawn_points = new List<Transform>();
    public int numberToSpawn = 1;
    void Start()
    {
        var tempArray = GameObject.FindGameObjectsWithTag("point"); // read all points
        List<GameObject> tempList = new List<GameObject>();
        tempList.AddRange(tempArray);

        for(int i =0;i<tempList.Count;i++)
        {
            if(!tempList[i].gameObject.GetComponent<point>().turn && !tempList[i].gameObject.GetComponent<point>().returnPossible)
            {
                all_spawn_points.Add(tempList[i].transform);
            }
                  
        }
        spawn_cars(numberToSpawn);
    }

  void spawn_cars(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            int random = Random.Range(0, all_spawn_points.Count - 1);
            GameObject car = (GameObject)Instantiate(Resources.Load("car"), all_spawn_points[random].position, Quaternion.identity);
            car.GetComponent<CarEngine>().direction = all_spawn_points[random].gameObject.GetComponent<point>().direction;  // set direction of car when spawn
            car.GetComponent<CarEngine>().start = all_spawn_points[random].gameObject;
            while(true)
            {
                int random2 = Random.Range(0, all_spawn_points.Count - 1);
                if (random == random2)
                {
                    continue;
                }

                car.GetComponent<CarEngine>().end = all_spawn_points[random2].gameObject;
                car.GetComponent<CarEngine>().pathTransforms = generatePath.find_path(all_spawn_points[random].gameObject, all_spawn_points[random2].gameObject);
                car.GetComponent<CarEngine>().spawnSet = true;
                break;
            }
        }
        
    }
}