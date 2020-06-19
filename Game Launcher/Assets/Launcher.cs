using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System.Diagnostics;
using System;
using System.Configuration;

public class Launcher : MonoBehaviour {
    public string Directory;
    public string URL;

    public void Player_Game() {
        Process.Start(Directory);
    }

    public void Quit_Launcher() {
        Application.Quit();
    }
       
    public void Open_Website() {
        Application.OpenURL(URL);
    }
}
