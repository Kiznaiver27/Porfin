using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _vel = 10f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + _vel * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - _vel * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position = new Vector3(transform.position.x - _vel * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position = new Vector3(transform.position.x + _vel * Time.deltaTime, transform.position.y, transform.position.z);
        }
    }
}
