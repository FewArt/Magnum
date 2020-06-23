using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject TutorialPanel;
    public float[] colors = new float[10];
    public float[] colorsMax = new float[10];
    
    public RectTransform rt;
    public GameObject gameObject1;
    public int paints;
    public int numberNow;
    //public int magicStick;
    //public int magicSearch;
    public bool magicStickActive;
    public bool magicSearchActive;
    public int  tutotialIsCompleted;
    public void UseMagickStick()
    {
        if(tutotialIsCompleted == 0)
        {
            Tutorial();
        }
    }
    public void UseMagickSearch()
    {
        if(tutotialIsCompleted == 0)
        {
            Tutorial();
        }
    }

    public void Tutorial()
    {
        gameObject1 = Instantiate(TutorialPanel, rt.transform);
        gameObject1.transform.SetParent(rt.transform);
    }

    void Start()
    {
        tutotialIsCompleted = PlayerPrefs.GetInt("TCompleted");
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("TCompleted", tutotialIsCompleted);
    }
}
