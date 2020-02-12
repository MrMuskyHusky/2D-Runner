using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public float score;
    public float pointIncreasePerSecond;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Distance: " + score;
        pointIncreasePerSecond = 1f;
        InvokeRepeating("TimerIncreaseTest", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        score += pointIncreasePerSecond * Time.deltaTime;
        scoreText.text = "Distance: " + Mathf.Round(score);
    }
    void TimerIncreaseTest()
    {
        pointIncreasePerSecond+=0.25f;
    }
}
