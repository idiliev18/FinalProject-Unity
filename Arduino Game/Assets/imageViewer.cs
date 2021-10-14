using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imageViewer : MonoBehaviour
{
    public GameObject image;
    public PlayerMovement playerMovement;
    public GameObject pauseMenu;
    public GameManager gameManager;

    public AchievementsManager achievementsManager;


    private void LateUpdate() 
    {
        if (image.active && Input.GetKeyDown(KeyCode.Escape))
        {
            image.SetActive(false);
            playerMovement.enabled = true;
            gameManager.ShowCanvas();
        }
    }

    private void OnMouseOver() 
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            image.SetActive(true);
            playerMovement.enabled = false;
            achievementsManager.unlockAchievement(achievementsManager.kondorianoAchievement);
        }
    }
}
