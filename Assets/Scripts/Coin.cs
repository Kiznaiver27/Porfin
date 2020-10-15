using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private enum Type { Spin, Horizontal, Vertical};
    [SerializeField] private Type type = Type.Spin;
    [SerializeField] private float _maxX = 1;
    [SerializeField] private float _maxY = 1;
    private Vector3 _positionInitial;
    [SerializeField] private bool _vuelta = false;
    private GameManager _Score;
    private void Start()
    {
        _Score = GetComponent<GameManager>();
        _positionInitial = this.gameObject.transform.position;
    }
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

        switch (type)
        {
            case Type.Spin:
                transform.Rotate(0, 50 * Time.deltaTime, 0);
                break;

            case Type.Horizontal:
                if (transform.position.x >= (_positionInitial.x + _maxX))
                {
                    _vuelta = false;
                }
                else if (transform.position.x <= _positionInitial.x)
                {
                    _vuelta = true;
                }
                if (_vuelta)
                {
                    transform.Translate(Vector3.right * Time.deltaTime, Space.World);
                }
                else
                {
                    transform.Translate(Vector3.left * Time.deltaTime, Space.World);
                }
                break;

            case Type.Vertical:
                if (transform.position.y >= (_positionInitial.y + _maxY))
                {
                    _vuelta = false;
                }
                else if (transform.position.y <= _positionInitial.y)
                {
                    _vuelta = true;
                }
                if (_vuelta)
                {
                    transform.Translate(Vector3.up * Time.deltaTime, Space.World);
                }
                else
                {
                    transform.Translate(Vector3.down * Time.deltaTime, Space.World);
                }
                break;
        }
    }
}
