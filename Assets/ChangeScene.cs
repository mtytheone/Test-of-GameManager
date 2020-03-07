using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.sceneLoaded += GameSceneLoad;
        SceneManager.LoadScene("AfterScene");
    }

    private void GameSceneLoad(Scene next, LoadSceneMode mode)
    {
        //GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        GameManager gameManager = GameManager.instance;
        gameManager.display = "Changed!";
        SceneManager.sceneLoaded -= GameSceneLoad;
    }
}
