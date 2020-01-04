using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    private GameManager _Gmanager;
    private Text text;

    void Start()
    {
        _Gmanager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        text = GetComponent<Text>();
        text.text = _Gmanager.display;
    }
}
