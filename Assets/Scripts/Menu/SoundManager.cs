using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    // Sound Manager is strictly for music used in the game

    #region Components
    [SerializeField] private Image musicOn;

    [SerializeField] private Image musicOff;

    private bool muted = false; 
    #endregion

    #region Start
    void Start()
    {
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else
        {
            Load();
        }
        UpdateButtonIcon();
        AudioListener.pause = muted;
    } 
    #endregion

    #region Icon Press
    public void OnButtonPress()
    {
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }
        else
        {
            muted = false;
            AudioListener.pause = false;
        }

        Save();
        UpdateButtonIcon();
    } 
    #endregion

    #region Icon Update
    private void UpdateButtonIcon()
    {
        if (muted == false)
        {
            musicOn.enabled = true;
            musicOff.enabled = false;
        }

        else
        {
            musicOn.enabled = false;
            musicOff.enabled = true;
        }
    } 
    #endregion

    #region Load
    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    } 
    #endregion

    #region Save
    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    } 
    #endregion
}
