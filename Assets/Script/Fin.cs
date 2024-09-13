using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class Fin : MonoBehaviour
{
    public Light2D indication;
    public GemCount playerGems;
    public int enoughGems;

    // Start is called before the first frame update
    void Start()
    {
        indication.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerGems.gemCount >= enoughGems)
        {
            indication.enabled = true;
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (playerGems.gemCount >= enoughGems)
        {
            SceneManager.LoadScene(2);
        }
    }

}   
