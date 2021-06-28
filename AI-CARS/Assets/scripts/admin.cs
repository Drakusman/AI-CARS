using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class admin : MonoBehaviour
{
    public List<Transform> all_spawn_points = new List<Transform>();
    public int numberToSpawn = 1;
    public int numberOfSpawn = 0;
    //lists of line, start points, end points
    public static List<GameObject> lines = new List<GameObject>();
    public static List<GameObject> points_start = new List<GameObject>();
    public static List<GameObject> points_end = new List<GameObject>();

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

  public void spawn_cars(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            if (amount >= numberToSpawn * 5)
            {
                Debug.LogError("Too many attempts to spawn!");
                break;
            }
            int random = Random.Range(0, all_spawn_points.Count - 1);

            Vector3 new_possition = all_spawn_points[random].position;
            if(Physics.CheckSphere(new_possition, 4f))
            {
                amount++;
                continue;
            }
            GameObject car = (GameObject)Instantiate(Resources.Load("car"), new_possition, Quaternion.identity);
            car.name = "car" + numberOfSpawn;
            numberOfSpawn++;
            car.GetComponent<CarEngine>().direction = all_spawn_points[random].gameObject.GetComponent<point>().direction;  // set direction of car when spawn
            car.GetComponent<CarEngine>().start = all_spawn_points[random].gameObject;
            while(true)
            {
                int random2 = Random.Range(0, all_spawn_points.Count - 1);
                if (random == random2)
                {
                    amount++;
                    continue;
                }

                car.GetComponent<CarEngine>().end = all_spawn_points[random2].gameObject;
                List<Transform> list = new List<Transform>();
                list = generatePath.find_path(all_spawn_points[random].gameObject, all_spawn_points[random2].gameObject);

                if(list.Count==0)
                {
                    Destroy(car);
                    numberOfSpawn--;
                    amount++;
                    break;
                }
                car.GetComponent<CarEngine>().pathTransforms = list;
                //generate lines, start points, end points

                GameObject point_start = Instantiate(Resources.Load<GameObject>("gizmo/sphere"));
                point_start.transform.position = list[0].position;
                point_start.GetComponent<MeshRenderer>().material = Resources.Load<Material>("material/start");
                point_start.SetActive(false);
                car.GetComponent<CarEngine>().start_point_gizmo = point_start;
                points_start.Add(point_start);

                GameObject point_end = Instantiate(Resources.Load<GameObject>("gizmo/sphere"));
                point_end.transform.position = list[list.Count-1].position;
                point_end.GetComponent<MeshRenderer>().material = Resources.Load<Material>("material/end");
                point_end.SetActive(false);
                car.GetComponent<CarEngine>().end_point_gizmo = point_end;
                points_end.Add(point_end);


                //lines
                GameObject line = Instantiate(Resources.Load<GameObject>("gizmo/line"));
                line.GetComponent<LineRenderer>().material = Resources.Load<Material>("material/line");
                line.GetComponent<LineRenderer>().startColor = Resources.Load<Material>("material/line_color").color;

                for (int j = 0; j < list.Count; j++)
                {
                    line.GetComponent<LineRenderer>().positionCount = list.Count;
                    line.GetComponent<LineRenderer>().SetPosition(j, list[j].position);
                }
                car.GetComponent<CarEngine>().line = line;
                line.SetActive(false);
                lines.Add(line);


                car.transform.LookAt(car.GetComponent<CarEngine>().pathTransforms[1]);
                car.GetComponent<CarEngine>().spawnSet = true;
                break;
            }
        }
        
    }
    public static void hide_Lines()
    {
        for (int i = 0; i < lines.Count; i++)
        {
            lines[i].SetActive(false);
        }
    }
    public static void hide_Starts()
    {
        for (int i = 0; i < points_start.Count; i++)
        {
            points_start[i].SetActive(false);
        }
    }
    public static void hide_Ends()
    {
        for (int i = 0; i < points_end.Count; i++)
        {
            points_end[i].SetActive(false);
        }
    }

}
