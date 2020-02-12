﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text timeText;
    public float playTime;
    private float currentTime = 0;

    public static bool canPlay = false;

    public GameObject win;
    public GameObject lose;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }

        if (canPlay == true)
        {
            playTime -= Time.deltaTime;
            timeText.text = "Time :" + Mathf.Round(playTime);

            if (playTime < 0)
            {
                canPlay = false;
            }
        }

        if (canPlay == false && playTime <= 0)
        {
            if(Sphere.sizeCheck >= 1.8 || Cube.sizeCheck >= 1.8)
            {
                win.SetActive(true);
            }

            else
            {
                lose.SetActive(true);
            }
        }
    }
}
