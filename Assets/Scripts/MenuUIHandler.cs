using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]

public class MenuUIHandler : MonoBehaviour
{
    public TMP_Text HighScoreText;

    void Start()
    {

    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void DisplayName(string name)
    {
        HighScoreText.text = "High Score: " + name;
    }

    public void SetName(string name)
    {
        if (PlayerPrefs.GetString("username") != name)
        {
            PlayerPrefs.SetString("username1", name);
            PlayerPrefs.Save();
            Debug.Log("username1: " + PlayerPrefs.GetString("username1"));
        }
        else
        {
            // PlayerPrefs.SetString("username", name);
            // PlayerPrefs.Save();
            Debug.Log("username: " + PlayerPrefs.GetString("username"));
        }
    }

    public void ClearPrefs()
    {
        PlayerPrefs.SetString("username", null);
        PlayerPrefs.SetString("username1", null);
        PlayerPrefs.SetInt("highscore", 0);
        PlayerPrefs.SetInt("currentscore", 0);
        PlayerPrefs.Save();
        Debug.Log(PlayerPrefs.GetString("username") + " " + PlayerPrefs.GetString("username1") + " " + PlayerPrefs.GetInt("highscore") + " " + PlayerPrefs.GetInt("highscore"));

    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
