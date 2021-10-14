using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class hideUnhide1 : MonoBehaviour
{
    public AchievementsManager achievementsManager;
    public GameObject unhideObject;

    public GameObject hint;

    void OnMouseOver()
    {
        if (hint != null)
        {
            hint.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (unhideObject != null)
            {
                unhideObject.SetActive(true);
                gameObject.SetActive(false);
            }

            if (this.name == "arduino 123" && achievementsManager != null)
            {
                achievementsManager.unlockAchievement(achievementsManager.arduinoAchievement);
            }

            if (this.name == "coffee mug - COFFEE MUG BODY-1" && achievementsManager != null)
            {
                achievementsManager.unlockAchievement(achievementsManager.coffeeAchievement);
            }
        }
    }
    
    void OnMouseExit()
    {
        if (hint != null)
        {
            hint.SetActive(false);
        }
    }
}
