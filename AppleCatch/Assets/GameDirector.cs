using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{

    GameObject timerText;
    float time = 60.0f;

    void Start()
    {
        this.timerText = GameObject.Find("Time");
    }

    void Update()
    {
        this.time -= Time.deltaTime;
        this.timerText.GetComponent<Text>().text = 
            this.time.ToString("F1");
    }
}