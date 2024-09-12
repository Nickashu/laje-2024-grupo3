using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float speed;
    public GameObject player;
    public UseLantern lantern;
    public bool standBy = false;




    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            standBy = true;
            Invoke("EndStandBy", 1);
        }
    }

    private Vector2 FindPath(Vector2 pointToFollow)
    {   
        List<Vector2> points = new List<Vector2>();

        for (int i = -8; i<=8; i++) 
        {
            for (int j = -8; j<=8; j++)
            {
                Vector2 point = new Vector2(pointToFollow.x - i * 0.64f, pointToFollow.y - j * 0.64f);

                Vector2 rayCastDirection = pointToFollow - point;
                rayCastDirection.Normalize();
                RaycastHit2D lineOfSite = Physics2D.Raycast(point, rayCastDirection, 5.12f);

                if (lineOfSite.collider != null)
                {
                    if (lineOfSite.transform.CompareTag("Player"))
                        points.Add(point);
                }
            }
            
        }

        if(points.Count == 0)
        {
            return pointToFollow;
        }

        Vector2 nearestPoint = points[0];
        float distanceToNearest = Vector2.Distance(transform.position, nearestPoint);

        for (int i = 1; i < points.Count; i++)
        {
            float distanceToCurrent = Vector2.Distance(transform.position, points[i]);
            if (distanceToNearest > distanceToCurrent)
            {
                nearestPoint = points[i];
                distanceToNearest = distanceToCurrent;
            }
        }

        return nearestPoint;
    }

    private void EndStandBy()
    {
        standBy = false;
    }

    public void PursuitPlayer()
    {
        if (!standBy)
        {
            Vector2 pointToFollow = player.transform.position;

            Vector2 rayCastDirection = player.transform.position - transform.position;
            rayCastDirection.Normalize();
            RaycastHit2D lineOfSite = Physics2D.Raycast(transform.position, rayCastDirection, Vector2.Distance(transform.position, player.transform.position));

            if (!lineOfSite.transform.CompareTag("Player"))
                pointToFollow = FindPath(pointToFollow);

            transform.position = Vector2.MoveTowards(transform.position, pointToFollow, speed * Time.deltaTime);

        }
    }

}
