using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListTiles : MonoBehaviour
{
    public GameManager gameManager;
    public List<GameObject> listTiles;
    private Color c;
    private SVGImage svg;
    public int paints;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        //gameManager.paints = paints;
        FillAListTiles();
        FillAListTilesMax();
    }

    public void UseMagicStick()
    {
        if (paints >=113 && gameManager.colors[gameManager.numberNow-1] != 0)
        {
            paints -= 113;
            for (int i = 0; i < listTiles.Count; i++)
            {
                if (listTiles[i].GetComponent<Tile>().number == gameManager.numberNow && listTiles[i].GetComponent<Button>().interactable == true)
                {
                    svg = listTiles[i].GetComponent<SVGImage>();
                    c = svg.color;
                    c.a = 1;
                    svg.color = c;
                    //listTiles[i].GetComponent<Tile>().isOpened = true;
                    gameManager.colors[gameManager.numberNow - 1] -= 1f;
                    listTiles[i].GetComponent<Button>().interactable = false;
                }

            }
        }
    }
    public void UseMagicSearch()
    {
        if (paints >= 32 && gameManager.colors[gameManager.numberNow-1] != 0)
        {
            paints -= 32;
            foreach (var a in listTiles)
            {
                if (a.GetComponent<Tile>().number == gameManager.numberNow && a.GetComponent<SVGImage>().color.a == 0)
                {
                    svg = a.GetComponent<SVGImage>();
                    c = svg.color;
                    c.a = 0.5f;
                    svg.color = c;
                }
            }
        }
    }

    void FillAListTilesMax()
    {
       gameManager.colorsMax[0] = 0;
       gameManager.colorsMax[1] = 0;
       gameManager.colorsMax[2] = 0;
       gameManager.colorsMax[3] = 0;
       gameManager.colorsMax[4] = 0;
       gameManager.colorsMax[5] = 0;
       gameManager.colorsMax[6] = 0;
       gameManager.colorsMax[7] = 0;
       gameManager.colorsMax[8] = 0;
       gameManager.colorsMax[9] = 0;
       foreach (var a in listTiles)
        {
            if (a.GetComponent<Tile>().number == 1)
            {
                gameManager.colorsMax[0] += 1;
            }
            else if (a.GetComponent<Tile>().number == 2)
            {
                gameManager.colorsMax[1] += 1;
            }
            else if (a.GetComponent<Tile>().number == 3)
            {
                gameManager.colorsMax[2] += 1;
            }
            else if (a.GetComponent<Tile>().number == 4)
            {
                gameManager.colorsMax[3] += 1;
            }
            else if (a.GetComponent<Tile>().number == 5)
            {
                gameManager.colorsMax[4] += 1;
            }
            else if (a.GetComponent<Tile>().number == 6)
            {
                gameManager.colorsMax[5] += 1;
            }
            else if (a.GetComponent<Tile>().number == 7)
            {
                gameManager.colorsMax[6] += 1;
            }
            else if (a.GetComponent<Tile>().number == 8)
            {
                gameManager.colorsMax[7] += 1;
            }
            else if (a.GetComponent<Tile>().number == 9)
            {
                gameManager.colorsMax[8] += 1;
            }
            else if (a.GetComponent<Tile>().number == 10)
            {
                gameManager.colorsMax[9] += 1;
            }
        }
    }

    void FillAListTiles()
    {
        gameManager.colors[0] = 0;
        gameManager.colors[1] = 0;
        gameManager.colors[2] = 0;
        gameManager.colors[3] = 0;
        gameManager.colors[4] = 0;
        gameManager.colors[5] = 0;
        gameManager.colors[6] = 0;
        gameManager.colors[7] = 0;
        gameManager.colors[8] = 0;
        gameManager.colors[9] = 0;
        foreach (var a in listTiles)
        {
            if (a.GetComponent<Tile>().number == 1 && a.GetComponent<Button>().interactable == true)
            {
                gameManager.colors[0] += 1;
            }
            else if (a.GetComponent<Tile>().number == 2 && a.GetComponent<Button>().interactable == true)
            {
                gameManager.colors[1] += 1;
            }
            else if (a.GetComponent<Tile>().number == 3 && a.GetComponent<Button>().interactable == true)
            {
                gameManager.colors[2] += 1;
            }
            else if (a.GetComponent<Tile>().number == 4 && a.GetComponent<Button>().interactable == true)
            {
                gameManager.colors[3] += 1;
            }
            else if (a.GetComponent<Tile>().number == 5 && a.GetComponent<Button>().interactable == true)
            {
                gameManager.colors[4] += 1;
            }
            else if (a.GetComponent<Tile>().number == 6 && a.GetComponent<Button>().interactable == true)
            {
                gameManager.colors[5] += 1;
            }
            else if (a.GetComponent<Tile>().number == 7 && a.GetComponent<Button>().interactable == true)
            {
                gameManager.colors[6] += 1;
            }
            else if (a.GetComponent<Tile>().number == 8 && a.GetComponent<Button>().interactable == true)
            {
                gameManager.colors[7] += 1;
            }
            else if (a.GetComponent<Tile>().number == 9 && a.GetComponent<Button>().interactable == true)
            {
                gameManager.colors[8] += 1;
            }
            else if (a.GetComponent<Tile>().number == 10 && a.GetComponent<Button>().interactable == true)
            {
                gameManager.colors[9] += 1;
            }
        }
    }


    void Update()
    {

    }
}
