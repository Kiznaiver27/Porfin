using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider ot)
    {
        if(ot.gameObject.tag == "Player")
        {
            ScoreScript.scoreValue++;
            LevelManager.CoinsRemaining++;
            Destroy(this.gameObject);
        }
    }
    void Update()
    {
        transform.Rotate(0, 1, 0);
    }
}
