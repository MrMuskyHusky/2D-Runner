using System.Collections;
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
        // If we press the space bar, we want to set the bool to true
        if(Input.GetKeyDown(KeyCode.Space))
        {
            hasStartTimer = true;
        }
        // if hasStartTimer is set to true, we want the score to start adding up.
        if(hasStartTimer == true)
        {
            score += pointIncreasePerSecond * Time.deltaTime;
            scoreText.text = "Distance: " + Mathf.Round(score);
        }
    }
    void TimerIncreaseTest()
    {
        // if hasStartTimer is set to true, we want the point increase 0.25 per seconds.
        if (hasStartTimer == true)
        {
            pointIncreasePerSecond += 0.25f;
        }
    }
}
