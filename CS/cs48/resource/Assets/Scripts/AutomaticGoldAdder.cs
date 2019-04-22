using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class AutomaticGoldAdder : MonoBehaviour
{
    // Update is called once per frame
    void Awake()
    {
        while (true)
        {

            Text gold = GameObject.Find("GoldCount").GetComponent<Text>();
            int goldCount = Int32.Parse(gold.text);
            Text goldMiner = GameObject.Find("GoldMinerCount").GetComponent<Text>();
            int goldMinerCount = Int32.Parse(goldMiner.text);
            if (goldMinerCount > 0)
            {
                goldCount = goldCount + 3 * goldMinerCount;
                gold.text = goldCount.ToString();
                Console.WriteLine("Gold is incremented!");
            }
        }
    }
       
        
    
}
