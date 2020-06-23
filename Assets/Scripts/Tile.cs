using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Tile : MonoBehaviour
{
    private GameManager gameManager;
    public int id;
    public int number;
    private SVGImage svg;
    private Color c;
    //public bool isOpened = false;
    //private ColorTile colorTile;

    private void Awake() {
        
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    
    }
    void Start()
    {
        svg = gameObject.GetComponent<SVGImage>();
        c = svg.color;
        c.a = 1;
    }
    public void OpenTile()
    {
        if(number == gameManager.numberNow && gameObject.GetComponent<Button>().interactable == true)
        {   
            svg.color = c;
            gameManager.colors[number-1] -= 1f;
            gameObject.GetComponent<Button>().interactable = false;
            //isOpened = true;           
        }
    }
}
