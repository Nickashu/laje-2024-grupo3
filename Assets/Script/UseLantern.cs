using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class UseLantern : MonoBehaviour
{
    public Light2D playerLight;
    public bool isLanternActive;
    public bool inUse = false;
    private bool inCoolDown = false;

    // Start is called before the first frame update
    void Start()
    {
        playerLight.pointLightOuterRadius = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isLanternActive && !inUse && !inCoolDown)
        {
            inUse = true;
            playerLight.pointLightOuterRadius = 4.5f;
            Invoke("TurnOfLantern", 3);
            Invoke("CoolDown", 5);
        }
    }

    void TurnOfLantern()
    {
        playerLight.pointLightOuterRadius = 2f;
        inCoolDown = true;
        inUse = false;
    }

    void CoolDown()
    {
        inCoolDown = false;
    }

}
