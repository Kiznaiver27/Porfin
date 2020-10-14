using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _vel = 10f;
    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        PlayerMovement();
    }
    private void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        Vector3 playerMovement = new Vector3(hor, 0f, ver).normalized * _vel * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
        if (!Input.GetKey(KeyCode.None))
        {
        }
    }
}
