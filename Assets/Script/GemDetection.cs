using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemDetection : MonoBehaviour
{ 
    public GameObject[] allObjectWithTag;
    public AlphaManager gemDetector;

    void Start()
    {
        allObjectWithTag = GameObject.FindGameObjectsWithTag("Gem");
    }

    // Update is called once per frame
    void Update()
    {

        GameObject nearestObject = allObjectWithTag[0];
        float distanceToNearest = Vector3.Distance(transform.position, nearestObject.transform.position);

        for (int i = 1; i < allObjectWithTag.Length; i++)
        {
            float distanceToCurrent = Vector3.Distance(transform.position, allObjectWithTag[i].transform.position);
            if (distanceToNearest<distanceToCurrent)
            {
                nearestObject = allObjectWithTag[i];
                distanceToNearest = distanceToCurrent;
            }
        }

        Vector3 collider = new Vector3(nearestObject.transform.position.x + 1f, nearestObject.transform.localPosition.y);
        gemDetector.setAlpha(Vector3.Distance(transform.position, collider));
        
    }
}
