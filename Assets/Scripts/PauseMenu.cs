using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] private GameObject panel;

    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            PauseUnpause();
        }
    }

    public void PauseUnpause()
    {
        if (!panel.activeInHierarchy)
        {
            panel.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            panel.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
