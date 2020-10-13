using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [SerializeField]
    private GameObject Panel;
    public void Restart()
    {
        Panel.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }

    public void Menu()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
