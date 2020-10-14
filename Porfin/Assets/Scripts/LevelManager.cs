using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private int CoinsInitials;
    public static int CoinsRemaining = 0;
    void Start()
    {
        CoinsInitials = GameObject.FindGameObjectsWithTag("Coin").Length;
    }

    void Update()
    {
        if (CoinsInitials == CoinsRemaining)
        {
            Time.timeScale = 0f;
            Debug.Log("Stop!");
        }
    }
}
