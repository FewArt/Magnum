using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorTile : MonoBehaviour
{
    public GameObject isChoosed;
    public int number;
    private GameManager gameManager;
    public float numberColor;
    public float maxNumberColor;
    private Image image;
    private ListTiles listTiles;
    // Start is called before the first frame update
    void Start()
    {
        maxNumberColor = 0;
        image = GetComponentInChildren<Image>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }

    public void UpdateMaxNumberColor()
    {
        maxNumberColor = gameManager.colorsMax[number-1];
    }

    public void СhooseColor()
    {
        gameManager.numberNow = number;
    }

    private void Update() 
    {
        CheckOnFillPaints();
        CheckOnChoose();
        UpdateColorNum();
        UpdateMaxNumberColor();
    }

    private void CheckOnChoose()
    {
        if(gameManager.numberNow == number)
        {
            isChoosed.SetActive(true);
        }
        else
        {
            isChoosed.SetActive(false);
        }
    }
    private void CheckOnFillPaints()
    {
        // if(numberColor==0)
        // {
        //     image.fillAmount = 1f-(gameManager.colors[number]/maxNumberColor);
        // }
        // else
        // {
        //     image.fillAmount = 1f-(gameManager.colors[number-1]/maxNumberColor); 
        // }
        image.fillAmount = 1f-(numberColor/maxNumberColor); 
    }
    private void UpdateColorNum() 
    {
        // if(number == 0)
        // {
        //     numberColor = gameManager.colors[number-1];
        // }
        // else
        // {
            numberColor = gameManager.colors[number-1];
        // }
            
    }
}
