using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createtower : MonoBehaviour
{
    Camera cam;
    public GameObject turrel;
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        if (Physics.Raycast(ray, out hit))
        {
            obj.transform.position = hit.point;
        }
        else
            obj.transform.position =new Vector3(0,-100,0);
        if (Input.GetMouseButtonDown(0))
        {
            
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.tag == "Terrain")
                {
                    Instantiate(turrel, hit.point, Quaternion.identity);
                }
            }
        }
    }
}
