using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MarketSceneSwitch : MonoBehaviour
{
    public void SwitchMarket()
    {
        SceneManager.LoadScene(sceneName: "MarketScene");
    }
}
