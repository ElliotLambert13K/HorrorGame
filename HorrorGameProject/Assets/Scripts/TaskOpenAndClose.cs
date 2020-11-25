using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskOpenAndClose : MonoBehaviour
{
    public GameObject MinigameCanvas;
    private bool minigameOpen = false;
    public bool TaskInteraction; 
    // Start is called before the first frame update
    void Start()
    {
        MinigameCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        OpenNClose();
    }

    void OpenNClose()
    {
        if (Input.GetButtonDown("Fire3"))
        {
            minigameOpen = !minigameOpen;
            if (minigameOpen && TaskInteraction == true)
            {
                MinigameCanvas.SetActive(true);
                Time.timeScale = 0;
                TaskInteraction = false;
            }

            if (!minigameOpen)
            {
                MinigameCanvas.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Task")
        {
            TaskInteraction = true;
        }
    }
}
