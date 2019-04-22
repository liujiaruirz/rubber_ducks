using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BakerAdd : MonoBehaviour
{
    public void IncrementBaker()
    {
        Text baker = GameObject.Find("BakerCount").GetComponent<Text>();
        int bakerCount = Int32.Parse(baker.text);
        Text worker = GameObject.Find("/Canvas/WorkerButton/WorkerCount").GetComponent<Text>();
        int workerCount = Int32.Parse(worker.text);


        if (workerCount >= 1)
        {
            bakerCount = bakerCount + 1;
            baker.text = bakerCount.ToString();
            workerCount = workerCount - 1;
            worker.text = workerCount.ToString();
        }
    }
}
