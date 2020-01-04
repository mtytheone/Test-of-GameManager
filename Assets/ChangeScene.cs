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
        GameManager GManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        GManager.display = "Changed!";
        SceneManager.sceneLoaded -= GameSceneLoad;
    }
}
