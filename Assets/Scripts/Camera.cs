using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    private GameObject _target;
    [SerializeField]
    private float x = 0, y = -5, z = 5;
    private void Awake()
    {
        _target = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (_target == null)
        {
            this.transform.position = new Vector3(0,5,0);
        }
        else
        {
            this.transform.position = new Vector3(_target.transform.position.x - x, _target.transform.position.y - y, _target.transform.position.z - z);
        }
    }
}
