using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tasks : MonoBehaviour
{
    public bool onTask = false;
    private GameObject checkpoint;
    private List<Transform> all_spawns;
    void Start()
    {
        checkpoint = Resources.Load<GameObject>("checkpoint");
        all_spawns = gameObject.GetComponent<admin>().all_spawn_points;
    }

    void Update()
    {
        if(onTask==false)
        {
            generateTask_checkpoint();
        }
    }
    public void generateTask_checkpoint()
    {
        int random = Random.Range(0, all_spawns.Count - 1);
        GameObject check = Instantiate(checkpoint, all_spawns[random].position,checkpoint.transform.rotation);
        Vector3 newPossition = new Vector3(check.transform.position.x, check.transform.position.y - 3f, check.transform.position.z);
        check.transform.position = newPossition;
        onTask = true;
    }
}
