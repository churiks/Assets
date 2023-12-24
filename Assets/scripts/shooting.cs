using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting: MonoBehaviour
{
    public string target;
    Animator animator;
    GameObject[] enemies;
    GameObject enemy;
    public float pover;
    float reload;
    public float range;
    bool shoot;

    void Start()
    {
        Invoke("hiit",1);
    }

    void hiit()
    {

        enemy.GetComponent<hpenemy>().power = pover;
        enemy.GetComponent<hpenemy>().timeot = 0;
        Invoke("hiit", reload);
    }

    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag(target);
        enemy = enemies[0];
        foreach (GameObject e in enemies)
        {
            e.GetComponent <hpenemy>().isAttacked = false;
            if (Vector3.Distance(transform.position, e.transform.position) < Vector3.Distance(transform.position, enemy.transform.position))
            {
                enemy = e;
            }
        }
        if (Vector3.Distance(transform.position, enemy.transform.position) < range)
        {
            enemy.GetComponent<hpenemy>().isAttacked = true;
            Vector3 direction = enemy.transform.position - transform.position;
            transform.rotation = Quaternion.LookRotation(direction);
        }
    }

}


