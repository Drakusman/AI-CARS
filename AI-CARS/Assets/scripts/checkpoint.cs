using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
  
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="player")
        {
            Destroy(gameObject.transform.parent);
        }
    }
}
