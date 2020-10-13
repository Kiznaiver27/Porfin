using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private int CoinsInitials = 0;
    public static int CoinsRemaining;
    [SerializeField]
    private GameObject Panel;
    [SerializeField]
    private GameObject Win;
    [SerializeField]
    private GameObject Lost;
    private GameObject _Player;

    void Start()
    {
        CoinsInitials = GameObject.FindGameObjectsWithTag("Coin").Length;
        _Player = GameObject.FindGameObjectWithTag("Player");
        Debug.Log(CoinsInitials);
    }

    void Update()
    {
        if (CoinsInitials == CoinsRemaining)
        {
            
            Panel.SetActive(true);
            Lost.SetActive(false);
            Win.SetActive(true);
        }
        if(_Player == null)
        {
            Panel.SetActive(true);
            Win.SetActive(false);
            Lost.SetActive(true);
        }
    }
}
