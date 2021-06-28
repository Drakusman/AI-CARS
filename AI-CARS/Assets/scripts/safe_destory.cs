using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safe_destory : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("admin").GetComponent<admin>().spawn_cars(1);
        Destroy(other.gameObject.transform.parent.parent.gameObject);
    }
}
