using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GemCount : MonoBehaviour
{
    public TextMeshProUGUI Counting;
    public int gemCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Counting.text = "x " + gemCount;
    }
}
