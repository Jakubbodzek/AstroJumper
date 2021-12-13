using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialLinks : MonoBehaviour
{
    public void OpenLinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/jakub-bodzek-7520881a4/");
    }

    public void OpenGitHub()
    {
        Application.OpenURL("https://github.com/Jakubbodzek");
    }

    public void OpenTrello()
    {
        Application.OpenURL("https://trello.com/b/Uo14yiDc/astrojumper");
    }
}
