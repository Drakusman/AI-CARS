using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_engine_collision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ai_car")
        {
            GameObject.Find("admin").GetComponent<admin>().spawn_cars(1);
            Destroy(gameObject);
        }
    }
}
