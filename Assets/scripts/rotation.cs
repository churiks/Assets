using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public float distance;
    public float attackDistance;
    public string target;

    Animator animator;
    GameObject enemy;
    void Start()
    {

    }
    void Update()
    {
        enemy = GameObject.FindGameObjectWithTag(target);
        animator = GetComponent<Animator>();

        Vector3 direction = enemy.transform.position - transform.position;
        



        if (direction.magnitude < distance)
        {
            transform.rotation = Quaternion.LookRotation(direction);

            if (Vector3.Distance(enemy.transform.position, transform.position) > attackDistance)
            {

                //animator.SetBool("walk", true);
                //animator.SetBool("attack", false);
                
            }
            else
            {
                //animator.SetBool("attack", true);
                //animator.SetBool("walk", false);
                Invoke("delay", animator.GetCurrentAnimatorStateInfo(0).length);
                
            }
        }
        else
        {
            
            //animator.SetBool("walk", false);
            //animator.SetBool("attack", false);
        }
    }
    
}


