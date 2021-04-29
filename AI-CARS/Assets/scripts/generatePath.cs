using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatePath
{

    public static List<Transform> find_path(GameObject start, GameObject end)
    {
        List<Transform> path = new List<Transform>();
        path.Add(start.transform);  //add start point   
        GameObject point = start;
        int safe_breaker = 10000;
        int counter = 0;
        while (true)
        {
            if (counter > safe_breaker)
            {
                Debug.LogError("Couldn't set path!!!");
                path = new List<Transform>();
                path.Add(start.transform);
                break;
            }
            
            Debug.Log(point.name);
            if (point == end)//check if next is end point
            {
                path.Add(end.transform);
                break;
            }
            if (point.GetComponent<point>().turn && point.GetComponent<point>().turnList.Count > 0 && point.GetComponent<point>().turnList[0] != null && point.GetComponent<point>().returnPossible)  //check if turn or return
            {
                for (int i = 0; i < point.GetComponent<point>().turnList.Count; i++) // check if turn is better then next
                {
                    if (Vector3.Distance(point.GetComponent<point>().turnList[i].transform.position, end.transform.position) < Vector3.Distance(point.transform.position, end.transform.position)) //check turn -> next
                    {
                        if (Vector3.Distance(point.GetComponent<point>().turnList[i].transform.position, end.transform.position) > Vector3.Distance(point.GetComponent<point>().returnPoint.transform.position, end.transform.position)) //check return -> turn
                        {
                            path.Add(point.transform);
                            path.Add(point.GetComponent<point>().returnPoint);
                            point = point.GetComponent<point>().returnPoint.gameObject;
                        }
                        else
                        {
                            path.Add(point.transform);
                            path.Add(point.GetComponent<point>().turnList[i]);
                            point = point.GetComponent<point>().turnList[i].gameObject;
                        }
                        break;
                    }
                }
            }
            else if (point.GetComponent<point>().turn && point.GetComponent<point>().turnList.Count > 0 && point.GetComponent<point>().turnList[0]!=null)  //check if turn or return
            {
                for (int i = 0; i < point.GetComponent<point>().turnList.Count; i++) // check if turn is better then next
                {
                    if (Vector3.Distance(point.GetComponent<point>().turnList[i].transform.position, end.transform.position) < Vector3.Distance(point.transform.position, end.transform.position)) //check turn -> next
                    {
                        path.Add(point.transform);
                        path.Add(point.GetComponent<point>().turnList[i]);
                        point = point.GetComponent<point>().turnList[i].gameObject;
                        break;
                    }
                }
            }
            else if (point.GetComponent<point>().returnPossible && Vector3.Distance(point.GetComponent<point>().returnPoint.position, end.transform.position) < Vector3.Distance(point.transform.position, end.transform.position))
            {
                path.Add(point.transform);
                path.Add(point.GetComponent<point>().returnPoint);
                point = point.GetComponent<point>().returnPoint.gameObject; // set next point
            }
            else
            {
                path.Add(point.transform);
                point = point.GetComponent<point>().next_point.gameObject; // set next point
            }

            counter++;
        }//while
        return path;
    }
}
