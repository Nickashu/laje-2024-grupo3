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
            alpha = 0.05f;
        else
            alpha = 0.05f + (10 - proximity)*0.05f;
        if (proximity < 0.5)
            alpha = 1f;

        if (!gemActive)
            alpha = 1f;

        image.color = new Color(image.color.r, image.color.g, image.color.b, alpha);
    }

}
