using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class GemInteraction : MonoBehaviour
{
    public GemCount playersGemCount;
    private bool isInRange;
    private bool isMining = false;
    private bool alreadyMined = false;
    private float miningTimeLeft = 5f;
    public SpriteRenderer gemSprite;
    public Sprite burried;
    public Sprite unburried;

    // Start is called before the first frame update
    void Start()
    {
        gemSprite.sprite = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange && Input.GetKey(KeyCode.E))
        {
            isMining = true;
            if(!alreadyMined)
                gemSprite.sprite = burried;
        }
        if (Input.GetKeyUp(KeyCode.E)) 
        {
            isMining = false;
            miningTimeLeft = 5f;
        }
        if (isMining && !alreadyMined)
        {
            if (miningTimeLeft > 0)
            {
                miningTimeLeft -= Time.deltaTime;
            }
            else
            {
                alreadyMined = true;
                playersGemCount.gemCount += 1;
                gemSprite.sprite = unburried;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;  
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
        }
    }


}
