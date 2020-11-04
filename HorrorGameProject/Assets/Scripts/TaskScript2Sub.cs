using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskScript2Sub : MonoBehaviour
{
    public int overallScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        overallScore = overallScore;
        Debug.Log("bruh");
    }

    void LateUpdate()
    {
        if (overallScore == 4)
        {
            Debug.Log("Full marks");
        }
        else if (overallScore == 3)
        {
            Debug.Log("3/4");
        }
    }
}
