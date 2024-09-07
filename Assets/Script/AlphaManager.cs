using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlphaManager : MonoBehaviour
{
    public Image image;

    public void setAlpha(float proximity)
    {
        if (proximity > 10)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        }
        else
        {
            float alpha = (10 - proximity)/10;
            image.color = new Color(image.color.r, image.color.g, image.color.b, alpha);
        }
    }

}
