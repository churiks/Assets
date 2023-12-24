using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemywalk : MonoBehaviour
{
    public float speed;
    public string tag;
    public Vector3 vec;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == tag)
        {
            transform.position += vec * speed;
        }
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
