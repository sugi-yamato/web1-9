﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

    GameObject timerText;
    GameObject pointText;
    float time = 30.0f;
    int point = 0;
    GameObject generator;

    public void GetApple()
    {
        this.point += 100;
    }
    public void GetBomb()
    {
        this.point /= -2;
    }


	// Use this for initialization
	void Start () {
        this.generator = GameObject.Find("ItemGenerator");
        this.timerText = GameObject.Find("Time");
        this.pointText = GameObject.Find("Point");
    }
	
	// Update is called once per frame
	void Update () {
        this.time -= Time.deltaTime;

        if(this.time < 0)
        {
            this.time = 0;
            this.generator.GetComponent<ItemGenerator>().SetParameter(
                10000.0f, 0, 0);
        }else if(0 <= this.time && this.time < 5)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(
                0.1f, -0.04f, 10);
        }
        else if (0 <= this.time && this.time < 10)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(
                0.2f, -0.06f, 10);
        }
        else if (0 <= this.time && this.time < 20)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(
                0.3f, -0.07f, 9);
        }
        else if (0 <= this.time && this.time < 30)
        {
            this.generator.GetComponent<ItemGenerator>().SetParameter(
                0.4f, -0.08f, 8);
        }


        this.timerText.GetComponent<Text>().text =
            this.time.ToString("F1");
        this.pointText.GetComponent<Text>().text =
            this.point.ToString() + "point";

    }
}
