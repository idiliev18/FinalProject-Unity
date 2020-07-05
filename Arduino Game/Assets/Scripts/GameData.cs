using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class GameData 
{
    public int level;

    public GameData (pinScript pinScript)
    {
        level = pinScript.level;
    }
}
