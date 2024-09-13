using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Teleport : MonoBehaviour
{
    public Teleport recievingCollider;
    public Collider2D porta;
    public Light2D indication;
    public GameObject player;
    public GemCount playerGems;
    public int enoughGems;
    public bool alreadyOpen = false;
    public bool recieved = false;


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
        if (playerGems.gemCount >= enoughGems && !recieved)
        {
            player.transform.position = porta.transform.position;
            recievingCollider.recieved = true;
            recievingCollider.alreadyOpen = true;
            if (!alreadyOpen)
                playerGems.gemCount -= enoughGems;
            alreadyOpen = true;


        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        recieved = false;
    }
}   
