﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public float score;
    public float pointIncreasePerSecond;

    public bool hasStartTimer;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Distance: " + score;
        pointIncreasePerSecond = 1f;
        InvokeRepeating("TimerIncreaseTest", 1, 1);
        hasStartTimer = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            hasStartTimer = true;
        }
        if(hasStartTimer == true)
        {
            score += pointIncreasePerSecond * Time.deltaTime;
            scoreText.text = "Distance: " + Mathf.Round(score);
        }
    }
    void TimerIncreaseTest()
    {
        if (hasStartTimer == true)
        {
            pointIncreasePerSecond += 0.25f;
        }
    }
}
