using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskOpenAndClose : MonoBehaviour
{
    public GameObject MinigameCanvas;
    private bool minigameOpen = false; 
    // Start is called before the first frame update
    void Start()
    {
        MinigameCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire3"))
        {
            minigameOpen = !minigameOpen;
            if (minigameOpen)
            {
                MinigameCanvas.SetActive(true);
                Time.timeScale = 0;
            }

            if (!minigameOpen)
            {
                MinigameCanvas.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }
}
