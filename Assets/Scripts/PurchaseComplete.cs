using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;

public class PurchaseComplete : MonoBehaviour
{
    public Spawn spawn;
    public GameManager gameManager;
    public ListTiles listTiles;

    public Text paints;
    public Text paintsGame;

    private void Start() 
    {
        listTiles = spawn.gameObject1.GetComponent<ListTiles>();
        DisplayMoney();
    }

    public void OnPurchaseComplete(Product product)
    {
        if(product.definition.id == "p1000")
        {
            listTiles.paints += 1000;
        }
        else if(product.definition.id == "p5000")
        {
            listTiles.paints += 7000;
        }
        else if(product.definition.id == "p10000")
        {
            listTiles.paints += 15000;
        }
        else if(product.definition.id == "p50000")
        {
            listTiles.paints += 55000;
        }
        else if(product.definition.id == "p150000")
        {
            listTiles.paints += 250000;
        }
        DisplayMoney();
    }

    public void OnPurchaseFailure(Product product, PurchaseFailureReason reason)
    {
        Debug.Log("Purchase of product" + product.definition.id + " failed because " + reason);
    }

    private void DisplayMoney()
    {

        if(listTiles.paints >= 0 && listTiles.paints <= 999)
        {
            paints.text = "150";
            paintsGame.text = "150";
        }
        else if(listTiles.paints >= 1000 && listTiles.paints <= 999999)
        {
            paints.text = "150k";
            paintsGame.text = "150k";
        }
        
    }

    public void BuyMagicStick()
    {
        if(listTiles.paints >= 1)
        {
            listTiles.paints -= 1;
        }
        DisplayMoney();
    }

    public void BuyMagicSearch()
    {
        if(listTiles.paints >= 20)
        {
            listTiles.paints -= 10;
        }
        DisplayMoney();
    }
}
