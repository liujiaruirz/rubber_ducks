﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldMinerAdd : MonoBehaviour
{
    public void IncrementGoldMiner()
    {
        Text goldMiner = GameObject.Find("GoldMinerCount").GetComponent<Text>();
        int goldMinerCount = Int32.Parse(goldMiner.text);
        Text worker = GameObject.Find("/Canvas/WorkerButton/WorkerCount").GetComponent<Text>();
        int workerCount = Int32.Parse(worker.text);


        if (workerCount >= 1)
        {
            goldMinerCount = goldMinerCount + 1;
            goldMiner.text = goldMinerCount.ToString();
            workerCount = workerCount - 1;
            worker.text = workerCount.ToString();
        }
    }
}
