using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class roundStart : MonoBehaviour
{
    float timeLeft = 3.0f;
    float timeStart = -2.0f;
    bool complete = false;
    bool intro = true;
    public Text text;

    void Update()
    {
            timeLeft -= Time.deltaTime;
            timeStart += Time.deltaTime; 
            text.text = "" + Mathf.Round(timeLeft);
            if (timeLeft < 0.5)
            {
                text.text = "GO!";
            }
            if (timeLeft < 0)
            {
                text.text = "" + Mathf.Round(timeStart);
                if(complete == true)
                {
                text.text = "Congratulations!";
                SceneManager.LoadScene("levelselect");
                }    
            }


            
    }

    public void victory()
    {
        complete = true;
        
    }
}
    
   /* void LateUpdate()
    {
        double timer = 0.0;
        if (timeLeft < 0)
        {
            timer += Time.deltaTime;
            text.text = "" + timer;
        }
    }*/