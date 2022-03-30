using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public Dropdown resolutionDropdown;
    public Toggle fullscreenToggle;
    public Text text;
    Resolution[] allResolutions;
    List<Resolution> resolutions = new List<Resolution>();

    void Start()
    {
        allResolutions = Screen.resolutions;

        resolutions.Add(allResolutions[0]);
        for(int i = 0; i < allResolutions.Length - 1; i++)
        {
            if(allResolutions[i].width != allResolutions[i + 1].width || allResolutions[i].height != allResolutions[i + 1].height)
            {
                resolutions.Add(allResolutions[i + 1]);
            }
        }

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        for(int i = 0; i < resolutions.Count; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = resolutions.Count - 1;
        resolutionDropdown.RefreshShownValue();

        Screen.SetResolution(resolutions[resolutions.Count - 1].width, resolutions[resolutions.Count - 1].height, Screen.fullScreen);
    }
   public void SetResolution()
    {
        int width = resolutions[resolutionDropdown.value].width;
        int height = resolutions[resolutionDropdown.value].height;
        Screen.SetResolution(width, height, Screen.fullScreen);
    }
   public void SetFullscreen ()
    {
        Screen.fullScreen = fullscreenToggle.isOn;
    }
}
