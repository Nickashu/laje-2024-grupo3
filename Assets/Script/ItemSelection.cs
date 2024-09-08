using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSelection : MonoBehaviour
{
    public Image primaryImage;
    public Image secondaryImage;
    public Sprite gemDetectorSprite;
    public Sprite lanternSprite;
    public AlphaManager gemDetector;
    public UseLantern lantern;

    // Start is called before the first frame update
    void Start()
    {
        primaryImage.sprite = gemDetectorSprite;
        secondaryImage.sprite = lanternSprite;
        gemDetector.gemActive = true;
        lantern.isLanternActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            gemDetector.gemActive = !gemDetector.gemActive;
            lantern.isLanternActive = ! lantern.isLanternActive;


            if (primaryImage.sprite == gemDetectorSprite)
            {
                primaryImage.sprite = lanternSprite;
                secondaryImage.sprite = gemDetectorSprite;
            }
            else
            {
                primaryImage.sprite = gemDetectorSprite;
                secondaryImage.sprite = lanternSprite;
            }
        }
    }
}
