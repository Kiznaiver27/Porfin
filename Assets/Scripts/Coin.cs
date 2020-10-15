using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private enum Type { Spin, Horizontal, Vertical};
    [SerializeField]
    private Type type = Type.Spin;

    private void OnTriggerEnter(Collider ot)
    {
        if(ot.gameObject.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Play("CollectCoin");
            GameManager.CoinsRemaining += 1;
            Destroy(this.gameObject);
        }
    }
    void Update()
    {
        if (type == Type.Spin)
        {
            transform.Rotate(0, 1, 0);
        }
        if (type == Type.Horizontal)
        {
            transform.Rotate(1, 0, 0);
        }
        if (type == Type.Vertical)
        {
            transform.Rotate(0, 0, 1);
        }
    }
}
