using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public bool random;
    public GameObject prefab;
    public float timeOut;
    public Transform spawn;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }


    void Spawn()
    {
        if (random == true)
        {
            Instantiate(prefab, spawn.position, Quaternion.identity);
            timeOut = Random.Range(0.1f, time);
            Invoke("Spawn", timeOut);
        }
        else
        {
            Instantiate(prefab, spawn.position, Quaternion.identity);
            timeOut = time;
            Invoke("Spawn", timeOut);
        }
        
    }
}
