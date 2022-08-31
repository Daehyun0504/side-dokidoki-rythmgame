using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterFrame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Note")
        {
            Debug.Log("dfd");
        }
    }
}
