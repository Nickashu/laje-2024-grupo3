using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlphaManager : MonoBehaviour
{
    public Image image;
    public bool gemActive;
    private float alpha = 0f;
    public void setAlpha(float proximity)
    {

        if (proximity > 10)
        {
            alpha = 0f;
        }
        else
        {
            alpha = (10 - proximity) / 10;
        }

        if (gemActive == false)
        {
            alpha = 1f;
        }

        image.color = new Color(image.color.r, image.color.g, image.color.b, alpha);
    }

}
