using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering.Universal;
using UnityEngine.UIElements;

public class PlayerHealth : MonoBehaviour
{
    private bool hit = false;
    public PlayerMovement playerMovement;
    public Rigidbody2D rb2D;
    public Light2D playerView;

    public UnityEvent OnBegin, OnEnd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            if (!hit)
            {
                hit = true;
                playerMovement.velocity = 2;
                StartCoroutine(FlickerLight());
                Invoke("RestoreHealth", 3);

            }
            else
            {
                Debug.Log("Game Over");
            }
        }
    }

    private IEnumerator FlickerLight()
    {
        while(hit)
        {
            yield return new WaitForSeconds(Random.Range(0.1f,0.5f));
            playerView.enabled = !playerView.enabled;
        }
        if(!playerView.enabled)
            playerView.enabled=true;
    }

 

    void RestoreHealth()
    {
        hit = false;
        playerMovement.velocity = 4;
    }
}
