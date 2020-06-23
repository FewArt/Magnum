using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.UI;

public class SaveAndLoad : MonoBehaviour
{
    public Spawn spawn; 
    public ListTiles listTiles;
    private Save sv = new Save();
    public string path;

    public void ResetSave()
    {
            path = Path.Combine(Application.dataPath, "Save.json");
            File.Delete(path);   
    }

    public void Load()
    {
        path = Path.Combine(Application.persistentDataPath, spawn.gameObject1.name.ToString()+".json");
        listTiles = spawn.gameObject1.GetComponent<ListTiles>();
        sv.coloring = new Color[listTiles.listTiles.Count];
        sv.isOpened = new bool[listTiles.listTiles.Count];
        if (File.Exists(path))
        {
            sv = JsonUtility.FromJson<Save>(File.ReadAllText(path));
            for (int i = 0; i < listTiles.listTiles.Count; i++)
            {
                listTiles.listTiles[i].GetComponent<Button>().interactable = sv.isOpened[i];
                listTiles.listTiles[i].GetComponent<SVGImage>().color = sv.coloring[i];
            }
            listTiles.paints = sv.paints;
        }
    }
    public void Save()
    {   
        //ResetSave();
        for (int i = 0; i < listTiles.listTiles.Count; i++)
        {
            sv.isOpened[i] = listTiles.listTiles[i].GetComponent<Button>().interactable;
            sv.coloring[i] = listTiles.listTiles[i].GetComponent<SVGImage>().color;
        }
        sv.paints = listTiles.paints;
        File.WriteAllText(path, JsonUtility.ToJson(sv));
    }
}

[Serializable]
public class Save
{
    public Color[] coloring;
    public int paints;
    public bool[] isOpened;
}
