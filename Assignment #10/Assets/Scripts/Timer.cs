/*
 * Kevon Long
 * Timer.cs
 * Assignment #8
 * Shows how long you've been alive
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timer;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 30.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timer.text = "" + time;

        if(time <= 0.0f)
        {
            if(Player.numOfDiamonds == 2)
            {
                SceneManager.LoadScene("WinScreen");
            }
            else
            {
                SceneManager.LoadScene("LoseScene");
            }
        }
    }
}
