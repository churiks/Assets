using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageenemy : MonoBehaviour
{

    public float damage;
    public float damageTimeOut;
    bool timeout = true;

    private void OnCollisionEnter(Collision collision)
    {
        collisionProcess(collision.gameObject);
    }
    private void OnCollisionStay(Collision collision)
    {
        collisionProcess(collision.gameObject);
    }
    private void OnTriggerEnter(Collider collision)
    {
        collisionProcess(collision.gameObject);
    }
    private void OnTriggerStay(Collider collision)
    {
        collisionProcess(collision.gameObject);
    }

    void collisionProcess(GameObject ob)
    {
        if (ob.tag == "tower hp")
        {
            
            ob.GetComponent<HP>().addHP(-damage);
            Destroy(gameObject);
        }
    }
}

