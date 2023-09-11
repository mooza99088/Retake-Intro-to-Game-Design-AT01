using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private GameHUD hud;
    private MouseLook mouseLook;

    private const int firstLevelIndex = 1;
    private static int nextSceneIndex = 1;


    private void Awake()
    {
        hud = FindObjectOfType<GameHUD>();
        mouseLook = FindObjectOfType<MouseLook>();
    }

    

    // Update is called once per frame

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }


}
