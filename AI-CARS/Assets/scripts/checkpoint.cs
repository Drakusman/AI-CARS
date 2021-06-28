using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Contains("player") && GameObject.Find("admin").GetComponent<tasks>().task_checkpoint)
        {
            GameObject.Find("admin").GetComponent<tasks>().onTask = false;
            GameObject.Find("admin").GetComponent<tasks>().task_checkpoint = false;
            Destroy(gameObject.transform.parent.gameObject);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag.Contains("player") && GameObject.Find("admin").GetComponent<tasks>().task_parking && other.gameObject.GetComponent<playerInteraction>().brake_on)
        {
            GameObject.Find("admin").GetComponent<tasks>().onTask = false;
            GameObject.Find("admin").GetComponent<tasks>().task_parking = false;
            Destroy(gameObject.transform.parent.gameObject);
        }
    }
}
