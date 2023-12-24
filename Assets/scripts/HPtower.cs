using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class HP : MonoBehaviour
{
    public Slider sliderObject;
    float hp = 100;
    bool alive = true;


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

    void Update()
    {
        sliderObject.value = hp / 100;

    }

    void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
