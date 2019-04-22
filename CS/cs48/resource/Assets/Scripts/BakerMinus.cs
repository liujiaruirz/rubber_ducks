using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BakerMinus : MonoBehaviour
{
    public void DecrementBaker()
    {
        Text baker = GameObject.Find("BakerCount").GetComponent<Text>();
        int bakerCount = Int32.Parse(baker.text);
        Text worker = GameObject.Find("/Canvas/WorkerButton/WorkerCount").GetComponent<Text>();
        int workerCount = Int32.Parse(worker.text);


        if (bakerCount >= 1)
        {
            bakerCount = bakerCount - 1;
            baker.text = bakerCount.ToString();
            workerCount = workerCount + 1;
            worker.text = workerCount.ToString();
        }
    }
}
