using UnityEngine;
using UnityEngine.SceneManagement;

public class Launcher : MonoBehaviour 
{
    public string URL;

    void Awake()
    {
        Screen.fullScreenMode = FullScreenMode.Windowed;
        Screen.SetResolution(1024, 768, false);
    }

    public void Player_Game() 
    {
        Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
        Screen.SetResolution(1920, 1080, true);
        SceneManager.LoadScene(1);
    }

    public void Quit_Launcher() 
    {
        Application.Quit();
    }
       
    public void Open_Website() 
    {
        Application.OpenURL(URL);
    }
}
