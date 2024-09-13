using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSelection : MonoBehaviour
{
    public Sprite gizmoNormal;
    public Sprite gizmoLantern;
    public Sprite purpleGem;
    public Sprite smallPurpleGem;
    public Sprite yellowGem;
    public Sprite smallYellowGem;
    public Image primaryImage;
    public Image secondaryImage;
    public Image gizmo;
    public AlphaManager gemDetector;
    public UseLantern lantern;

    // Start is called before the first frame update
    void Start()
    {
        primaryImage.sprite = purpleGem;
        secondaryImage.sprite = smallYellowGem;
        gizmo.sprite = gizmoNormal;
        gemDetector.gemActive = true;
        lantern.isLanternActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            gemDetector.gemActive = !gemDetector.gemActive;
            lantern.isLanternActive = !lantern.isLanternActive;


            if (primaryImage.sprite == purpleGem)
            {
                gizmo.sprite = gizmoLantern;
                primaryImage.sprite = yellowGem;
                secondaryImage.sprite = smallPurpleGem;
            }
            else
            {
                gizmo.sprite = gizmoNormal;
                primaryImage.sprite = purpleGem;
                secondaryImage.sprite = smallYellowGem;
            }
        }
    }
}
