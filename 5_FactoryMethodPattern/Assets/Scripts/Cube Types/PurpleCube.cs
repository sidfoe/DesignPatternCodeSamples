﻿/*
 * Sydney Foe
 * PurpleCube
 * Assignment 6
 * Changes the color of the food to be the food type that it is
 * */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleCube : Food
{
    public override void ChangeColor()
    {
        Color c = new Color(.65f, .08f, .9f, 1);
        GetComponent<MeshRenderer>().material.color = c;
    }
}