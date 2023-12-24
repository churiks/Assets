using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class hpenemy : MonoBehaviour
{
    public float armor;
    float hp = 100;
    public Slider sliderObject;
    bool alive = true;
    public bool isAttacked;
    public float power;
    public float timeot;

    void Start()
    {
        if (armor < 1)
        {
            armor = 1;
        }

    }
    public void addHP(float points)
    {
        if (hp > 0)
            hp = hp + points;
        if (hp > 100)
            hp = 100;
        if (hp <= 0 && alive)
        {
            hp = 0;
            alive = false;

        }
    }

    void DoDamage()
    {
        if (isAttacked = true)
        {
            hp = hp - ( power / armor );
        }
        sliderObject.value = hp / 100;

    }

    

}
