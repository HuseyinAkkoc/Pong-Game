using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuButtons : MonoBehaviour
{
    public Button playButton;
    public Button settingsButton;
    public Button exitButton;
    public Button instructionButton;


    public MMAudioManager audioManager;
   
   

    public void PlayButton(int sceneIndex)
    {
       
        audioManager.PlayButtonClickSound();
        StartCoroutine(LoadSceneDelayed(sceneIndex));

    }

    public void SettingsButton()
    {

        audioManager.PlayButtonClickSound();
        Debug.Log("settings button pressed.");
    }

    public void ExitButton()
    {
        audioManager.PlayButtonClickSound();
        Debug.Log("exit button pressed.");
    }

    public void InstructionButton()
    {
        audioManager.PlayButtonClickSound();
        Debug.Log("instructions button pressed.");
    }

    IEnumerator LoadSceneDelayed(int sceneIndex)
    {
        yield return new WaitForSecondsRealtime(0.2f);
        Debug.Log("play button pressed.");
        SceneManager.LoadScene(sceneIndex);
    }

}
