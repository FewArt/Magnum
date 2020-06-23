using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    public GameManager gameManager;
    public SaveAndLoad saveAndLoad;
    public ListTiles listTiles;
    private RectTransform rt;
    public GameObject gameObject1;
    public List<GameObject> tiles;
  
    // Start is called before the first frame update
    void Awake()
    {
        rt = GetComponent<RectTransform> ();
    }
    
    private void Start() {
        
    }

    public void SpawnImage(int num)
    {
        gameObject1 = Instantiate(tiles[num],rt.transform);
        gameObject1.transform.SetParent(rt.transform);
        saveAndLoad.Load();
        listTiles = gameObject1.GetComponent<ListTiles>();
    }

    // Update is called once per frame
    public void DestroyImage()
    {
        Destroy(gameObject1);
    }

    public void UseMagicStick()
    {
        //listTiles =  gameObject1.GetComponent<ListTiles>();
        listTiles.UseMagicStick();
    }
    public void UseMagicSearch()
    {
        //listTiles =  gameObject1.GetComponent<ListTiles>();
        listTiles.UseMagicSearch();
    }
}
