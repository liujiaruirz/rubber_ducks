using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldAddController : MonoBehaviour
{
    public void IncrementCount()
    {
        Text txt = transform.Find("GoldCount").GetComponent<Text>();
        int count = Int32.Parse(txt.text);
        count = count + 1;
        txt.text = count.ToString();
    }
}
