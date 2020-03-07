using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    private GameManager _gameManager;
    private Text text;

    void Start()
    {
        //_gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        _gameManager = GameManager.instance;
        text = GetComponent<Text>();
        text.text = _gameManager.display;
    }
}
