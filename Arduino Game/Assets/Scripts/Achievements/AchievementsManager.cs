using AOT;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using TMPro;

public class AchievementsManager : MonoBehaviour
{
    public Achievement theStartAchievement = new Achievement(11, "The Start");
    public Achievement thePushAchievement = new Achievement(12, "The Push");
    public Achievement adventureAchievement = new Achievement(13, "On a long adventure");
    public Achievement whatGreatVideoAchievement = new Achievement(14, "What a great video");
    public Achievement arduinoAchievement = new Achievement(15, "What is this?");
    public Achievement classAchievement = new Achievement(16, "The Secret Class");
    public Achievement christmassAchievement = new Achievement(17, "Merry Christmas (Every day can be Christmas)");
    public Achievement dejaVuAchievement = new Achievement(18, "Deja Vu");
    public Achievement coffeeAchievement = new Achievement(19, "Coffee is the best, served bitter and strong");
    public Achievement kondorianoAchievement = new Achievement(20, "The truth about Kondoriano");

    public TextMeshProUGUI AchievementText;

    private void Start() {
        string str = LocalStorageSystem.LoadLocalStorage();
        string[] int_arr = str.Split(' ');
        
        foreach (var i in int_arr) {
            if (i == theStartAchievement.id.ToString()) {
                theStartAchievement.isAchieved = true;
            }
            if (i == thePushAchievement.id.ToString()) {
                thePushAchievement.isAchieved = true;
            }
            if (i == adventureAchievement.id.ToString()) {
                adventureAchievement.isAchieved = true;
            }
            if (i == whatGreatVideoAchievement.id.ToString()) {
                whatGreatVideoAchievement.isAchieved = true;
            }
            if (i == arduinoAchievement.id.ToString()) {
                arduinoAchievement.isAchieved = true;
            }
            if (i == classAchievement.id.ToString()) {
                classAchievement.isAchieved = true;
            }
            if (i == christmassAchievement.id.ToString()) {
                christmassAchievement.isAchieved = true;
            }
            if (i == dejaVuAchievement.id.ToString()) {
                dejaVuAchievement.isAchieved = true;
            }
            if (i == coffeeAchievement.id.ToString()) {
                coffeeAchievement.isAchieved = true;
            }
            if (i == kondorianoAchievement.id.ToString()) {
                kondorianoAchievement.isAchieved = true;
            }
        }
    }

    public void unlockAchievement(Achievement achievement)
    {
        if (achievement.isAchieved == false)
        {
            achievement.isAchieved = true;
            Debug.Log("Achievement unlocked: " + achievement.name);
            StartCoroutine(ShowText(achievement));
            LocalStorageSystem.SaveLocalStorage(achievement.id);
        } 
        else
        {
            Debug.Log("Achievement already unlocked: " + achievement.name);
        }
    }

    IEnumerator ShowText(Achievement achievement)
    {
        if (achievement.isAchieved == true)
        {
            AchievementText.text = "Achievement Unlocked:\n" + achievement.name;
        }
        yield return new WaitForSecondsRealtime(3);
        AchievementText.text = "";
    }
}
