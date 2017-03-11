using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class roundStart : MonoBehaviour
{
    float timeLeft = 3.0f;

    public Text text;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        text.text = "" + Mathf.Round(timeLeft);
        if (timeLeft < 0)
        {
            text.text = "GO!";
        }
    }

void TimerStart()
    {
        double timer = 0.0;
        timer += Time.deltaTime;
    }
}