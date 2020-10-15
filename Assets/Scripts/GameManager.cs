using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{ 
    //Status of Game
    public enum Status { InGame, Stop};
    public static Status status;
    //Coins
    private int CoinsInitials = 0;
    public static int CoinsRemaining = 0;

    //Score
    [SerializeField] private Text scoreText;

    //Result
    [SerializeField] private GameObject Panel;
    [SerializeField] private GameObject Win;
    [SerializeField] private GameObject Lost;
    private GameObject _Player;

    //Camera
    public GameObject cam1, cam2;

    void Start()
    {
        Time.timeScale = 1;
        cam1.SetActive(true);
        cam2.SetActive(false);
        //
        status = Status.InGame;
        Panel.SetActive(false);

        //Find Objects
        CoinsInitials = GameObject.FindGameObjectsWithTag("Coin").Length;
        _Player = GameObject.FindGameObjectWithTag("Player");

    }

    void Update()
    {
        //Score
        scoreText.text = "Score: " + CoinsRemaining + " / " + CoinsInitials;

        //Panel Activate
        //Win
        if (CoinsInitials == CoinsRemaining)
        {
            Result(Win,Lost);
            CoinsRemaining = 0;
        }
        //Lost (Player Death)
        if(_Player == null)
        {
            cam2.SetActive(true);
            Result(Lost, Win);
            CoinsRemaining = 0;
        }
        MoveCursor();
    }
    private void Result(GameObject _true,GameObject _false)
    {
        Panel.SetActive(true);
        _true.SetActive(true);
        _false.SetActive(false);
        status = Status.Stop;
        
    }
    private void MoveCursor()
    {
        if (status == Status.Stop)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
        }
    }
}
