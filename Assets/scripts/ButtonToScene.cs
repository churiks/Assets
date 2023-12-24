using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonToScene : MonoBehaviour
{
    public string sceneName;
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(ChangeScene);
    }

    // Update is called once per frame
    void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
