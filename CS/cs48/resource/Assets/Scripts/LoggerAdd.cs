using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoggerAdd : MonoBehaviour
{
    public void LoggerIncrement()
    {
        Text logger = GameObject.Find("LoggerCount").GetComponent<Text>();
        int loggerCount = Int32.Parse(logger.text);
        Text worker = GameObject.Find("/Canvas/WorkerButton/WorkerCount").GetComponent<Text>();
        int workerCount = Int32.Parse(worker.text);


        if (workerCount >= 1)
        {
            loggerCount = loggerCount + 1;
            logger.text = loggerCount.ToString();
            workerCount = workerCount - 1;
            worker.text = workerCount.ToString();
        }
    }
}
