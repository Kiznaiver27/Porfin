using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{
    private void OnTriggerEnter(Collider ot)
    {
        if(ot.gameObject.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Stop("MainMusic");
            FindObjectOfType<AudioManager>().Play("Death");
            Destroy(ot.gameObject);
        }
    }
}
