using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarketMenu : MonoBehaviour
{
    public Button ButtonOpenMarket;
    public static bool MarketIsOpen = false;
    public GameObject UIMarket;

    public void Awake()
    {
        ButtonOpenMarket.onClick.AddListener(OpenAndCloseMarket);
    }
    void OpenAndCloseMarket()
    {
        if(MarketIsOpen == false)
        {
            UIMarket.SetActive(true);
            MarketIsOpen = true;
        }
        else if(MarketIsOpen == true)
        {
            UIMarket.SetActive(false);
            MarketIsOpen = false;
        }
    }
}
