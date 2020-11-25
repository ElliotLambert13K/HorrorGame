using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskScript2Sub : MonoBehaviour
{
    public int overallScore = 0;
    public GameObject ButtonRight1;
    public GameObject ButtonWrong1;
    public GameObject TickRight1;
    public GameObject TickWrong1;
    public GameObject ButtonRight2;
    public GameObject ButtonWrong2;
    public GameObject TickRight2;
    public GameObject TickWrong2;
    public GameObject ButtonRight3;
    public GameObject ButtonWrong3;
    public GameObject TickRight3;
    public GameObject TickWrong3;
    public GameObject ButtonRight4;
    public GameObject ButtonWrong4;
    public GameObject TickRight4;
    public GameObject TickWrong4;
    //private bool QuestionAnswered = false;
    // Start is called before the first frame update
    void Start()
    {
        TickRight1.SetActive(false);
        TickWrong1.SetActive(false);
        TickRight2.SetActive(false);
        TickWrong2.SetActive(false);
        TickRight3.SetActive(false);
        TickWrong3.SetActive(false);
        TickRight4.SetActive(false);
        TickWrong4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
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
        else if (overallScore == 2)
        {
            Debug.Log("2/4");
        }
        else if (overallScore == 1)
        {
            Debug.Log("1/4");
        }
        else
        {
            Debug.Log("0/4");
        }
    }

    public void OnClickAnswer1(bool answer1)
    {
        if (answer1 == true)
        {
            overallScore += 1;
            ButtonRight1.SetActive(false);
            ButtonWrong1.SetActive(false);
            TickRight1.SetActive(true);
        }
        else if (answer1 != true)
        {
            overallScore += 0;
            ButtonRight1.SetActive(false);
            ButtonWrong1.SetActive(false);
            TickWrong1.SetActive(true);
        }
    }

    public void OnClickAnswer2(bool answer2)
    {
        if (answer2 == true)
        {
            overallScore += 1;
            ButtonRight2.SetActive(false);
            ButtonWrong2.SetActive(false);
            TickRight2.SetActive(true);
        }
        else if (answer2 != true)
        {
            overallScore += 0;
            ButtonRight2.SetActive(false);
            ButtonWrong2.SetActive(false);
            TickWrong2.SetActive(true);
        }
    }

    public void OnClickAnswer3(bool answer3)
    {
        if (answer3 == true)
        {
            overallScore += 1;
            ButtonRight3.SetActive(false);
            ButtonWrong3.SetActive(false);
            TickRight3.SetActive(true);
        }
        else if (answer3 != true)
        {
            overallScore += 0;
            ButtonRight3.SetActive(false);
            ButtonWrong3.SetActive(false);
            TickWrong3.SetActive(true);
        }
    }

    public void OnClickAnswer4(bool answer4)
    {
        if (answer4 == true)
        {
            overallScore += 1;
            ButtonRight4.SetActive(false);
            ButtonWrong4.SetActive(false);
            TickRight4.SetActive(true);
        }
        else if (answer4 != true)
        {
            overallScore += 0;
            ButtonRight4.SetActive(false);
            ButtonWrong4.SetActive(false);
            TickWrong4.SetActive(true);
        }
    }
}
