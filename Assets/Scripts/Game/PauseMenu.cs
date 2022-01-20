using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] private GameObject pauseMenu;

    bool gamePaused;

    void Update()
    {    
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gamePaused = !gamePaused;
        }
            
        if (gamePaused)
        {
            pauseMenu.SetActive(true);
        }
         
        else
        {
            pauseMenu.SetActive(false);
        }
    }
}
