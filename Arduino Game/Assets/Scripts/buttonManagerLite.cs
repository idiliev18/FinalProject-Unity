using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.IO;

public class buttonManagerLite : MonoBehaviour
{

    public int level = 2;

    public pinScript pinScript;
    
    public void Awake()
    {
        string path = Application.persistentDataPath + "/data.haka";
        Debug.Log(path);

        if (!File.Exists(path))
        {
            SaveSystem.SaveData(pinScript);
        }
    }


    public void Play()
    {
        GameData data = SaveSystem.LoadGame();
        level = data.level;
            
        SceneManager.LoadScene(level);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
