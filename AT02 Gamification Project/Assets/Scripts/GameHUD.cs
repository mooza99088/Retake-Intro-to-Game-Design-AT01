using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHUD : MonoBehaviour
{

    [Tooltip("A reference to the game object pause menu.")]
    [SerializeField] private GameObject pauseMenu;


    public bool CursorEnabled
    {
        set
        {
            Cursor.visible = value;
            if (value == true)
            {
                Cursor.lockState = CursorLockMode.Confined;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
    /// <summary>
    /// toggle pause menu off if it is on.
    /// </summary>
    void Start()
    {
        if (pauseMenu == true)
        {
            TogglePauseMenu();
        }
    }

    /// <summary>
    /// toggles the pause menu and cursor state
    /// </summary>
    /// <returns></returns>
    public bool TogglePauseMenu()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
        CursorEnabled = pauseMenu.activeSelf;
        return pauseMenu.activeSelf;
    }

    
}
