using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleAppear : MonoBehaviour
{

    public bool isImgOn;
    public Image img;
    public bool isLateTitleOn;
    public Image LateTitle;
    float timer = 8.3F;

    void Start()
    {
        img.enabled = false;
        isImgOn = false;
        LateTitle.enabled = false;
        isLateTitleOn = false;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0.0)
        {
            if (isImgOn == false)
            {

                img.enabled = true;
                isImgOn = true;
            }

            else
            {

                img.enabled = true;
                isImgOn = true;
            }
        }
        if (timer < -21.5)
        {
            if (isLateTitleOn == false)
            {

                LateTitle.enabled = true;
                isLateTitleOn = true;
            }

            else
            {

                LateTitle.enabled = true;
                isLateTitleOn = true;
            }
        }
    }
    void LateUpdate()
    {
        if (timer < -15.4)
        {
            Vector3 moveDown = new Vector3(0, -1.0F, 0);
            transform.Translate(moveDown);
        }
    }
}