using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuAnimations : MonoBehaviour
{
    [SerializeField] private RectTransform mainPanel, optionsPanel, creditsPanel;

    public void OpenOptionsPanel()
    {
        mainPanel.DOAnchorPos(new Vector2(-460, -320), .4f);
        mainPanel.DOScale(0, .4f);
        optionsPanel.DOAnchorPos(new Vector2(0, 0), .4f);
        optionsPanel.DOScale(1, .4f);
    }
    public void ExitOptionsPanel()
    {   
        optionsPanel.DOAnchorPos(new Vector2(-460, -320), .4f);
        optionsPanel.DOScale(0, .4f);
        mainPanel.DOAnchorPos(new Vector2(0, 0), .4f);
        mainPanel.DOScale(1, .4f);
    }
    public void OpenCreditsPanel()
    {

    }
    public void ExitCreditsPanel()
    {

    }
}
