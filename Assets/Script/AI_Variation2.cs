using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Variation2 : EnemyAI
{
    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, player.transform.position) <= 5.12 && lantern.inUse)
            speed = -1f;

        if (Vector2.Distance(transform.position, player.transform.position) <= 5.12 || lantern.inUse)
            PursuitPlayer();


    }
}

