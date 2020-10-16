using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scalable : MonoBehaviour
{
    private void OnTriggerEnter(Collider ot)
    {
        if (ot.gameObject.CompareTag("Player"))
        {
            ot.gameObject.GetComponent<Rigidbody>().useGravity = false;
            //ot.gameObject.GetComponent<Rigidbody>();
        }
    }
    private void OnTriggerExit(Collider ot)
    {
        ot.gameObject.GetComponent<Rigidbody>().useGravity = true;
    }
}
