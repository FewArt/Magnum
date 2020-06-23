using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    private int paints;
    public GameObject mainMenuPanel;
    public GameObject infoPanel;
    public GameObject shopPanel;
    public GameObject gamePanel;
    public GameObject settingsPanel;
    public GameObject[] borders = new GameObject[4];
    public Spawn spawn;

    // Start is called before the first frame update
    void Start()
    {
        mainMenuPanel.SetActive(true);
        infoPanel.SetActive(false);
        gamePanel.SetActive(false);
    }

    public void GoToMenu()
    {
        mainMenuPanel.SetActive(true);
        infoPanel.SetActive(false);
        borders[0].SetActive(true);
        borders[3].SetActive(false);
    }
    public void GoToInfo()
    {
        mainMenuPanel.SetActive(false);
        infoPanel.SetActive(true);
        borders[0].SetActive(false);
        borders[3].SetActive(true);
    }

    public void Shop()
    {
        if(shopPanel.activeSelf)
        {
            shopPanel.SetActive(false);
        }
        else
        {
            shopPanel.SetActive(true);
        }
    }

    public void BackToMenu()
    {
        spawn.DestroyImage();
        gamePanel.SetActive(false);
        mainMenuPanel.SetActive(true);
        settingsPanel.SetActive(false);
        
    }
    public void StartGame()
    {
        gamePanel.SetActive(true);
        mainMenuPanel.SetActive(false);
    }

    public void GoToSettings()
    {
        if(settingsPanel.activeSelf)
        {
            settingsPanel.SetActive(false);
        }
        else
        {
            settingsPanel.SetActive(true);
        }
    }

}
