﻿/*
 * Sydney Foe
 * Assignment 10
 * ScoreSingleton
 * Sets up the score handler. Displays score to screen, also a function to add the points to the score.
 */

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSingleton : MonoBehaviour
{
    public static ScoreSingleton instance;

    public int score = 0;
    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ScoreAdd(int s)
    {
        score += s;

        scoreText.text = "Score: " + score;
    }
}