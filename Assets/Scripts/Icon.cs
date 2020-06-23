using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icon : MonoBehaviour
{
    public int id;
    public Spawn spawn;

    public void GetIdIcon()
    {
        spawn.SpawnImage(id);
    }
}
