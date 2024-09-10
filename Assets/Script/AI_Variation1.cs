using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Variation1 : EnemyAI
{
    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, player.transform.position) <= 5.12 && lantern.inUse)
            speed = 2.5f;

        if (Vector2.Distance(transform.position, player.transform.position) <= 5.12 || lantern.inUse)
            PursuitPlayer();


    }
}
