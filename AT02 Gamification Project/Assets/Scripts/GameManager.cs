using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private GameHUD hud;
    private MouseLook mouseLook;
    private bool gamePaused = false;

    private const int firstLevelIndex = 1;
    private static int nextSceneIndex = 1;


    private void Awake()
    {
        hud = FindObjectOfType<GameHUD>();
        mouseLook = FindObjectOfType<MouseLook>();
    }

    // Start is called before the first frame update
    void Start()
    {
        gamePaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab) == true)
        {
            TogglePauseGame();
        }     
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1;
        nextSceneIndex = firstLevelIndex;
        SceneManager.LoadScene(0);
    }

    public void TogglePauseGame()
    {
        gamePaused = hud.TogglePauseMenu();
        mouseLook.MouseLookEnabled = !gamePaused;
   
        if(gamePaused == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
