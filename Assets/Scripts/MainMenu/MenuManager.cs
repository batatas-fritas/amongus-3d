using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuToggles : MonoBehaviour
{
    public Canvas MenuCanvas;
    public Canvas SettingsCanvas;

    // Start is called before the first frame update
    void Start()
    {
        ChangeToMainMenu();
    }

    public void ChangeToMainMenu()
    {
        MenuCanvas.enabled = true;
        SettingsCanvas.enabled = false;
    }

    public void ChangeToSettings()
    {
        MenuCanvas.enabled = false;
        SettingsCanvas.enabled = true;
    }
}
