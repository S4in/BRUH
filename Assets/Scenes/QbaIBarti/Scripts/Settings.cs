using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Toggle fullScreenToggle;
    public TMPro.TMP_Dropdown resolutionDropdown;
    Resolution[] resolutions;
    void Start()
    {
       resolutions = Screen.resolutions;
        fullScreenToggle.onValueChanged.AddListener(delegate { FullScreen(); });
        resolutionDropdown.options.Clear();
        resolutionDropdown.onValueChanged.AddListener(delegate { OnResolutionChange(); });
        foreach(Resolution resolution in resolutions)
        {
            
            resolutionDropdown.options.Add(new TMPro.TMP_Dropdown.OptionData(resolution.width+ " x "+ resolution.height));
        }
    }

    public  void OnResolutionChange()
    {
        Screen.SetResolution(resolutions[resolutionDropdown.value].width, resolutions[resolutionDropdown.value].height, Screen.fullScreen);
    }

    

    
    public void FullScreen()
    {
        Screen.fullScreen = fullScreenToggle.isOn;
    }
    public void GetBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
