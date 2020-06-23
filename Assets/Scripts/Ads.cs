using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Ads : MonoBehaviour
{
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GetComponent<GameManager>();
        if(Advertisement.isSupported)
        {
            Advertisement.Initialize("3652059", true);
        }
    }

    public void showVideoAds()
    {
        if(Advertisement.IsReady())
        {
            Advertisement.Show("video");
            gameManager.paints += 20;
        }
    }
}
