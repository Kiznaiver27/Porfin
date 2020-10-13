using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{
    private void OnTriggerEnter(Collider ot)
    {
        if(ot.gameObject.tag == "Player")
        {
            Destroy(ot.gameObject);
        }
    }
}
