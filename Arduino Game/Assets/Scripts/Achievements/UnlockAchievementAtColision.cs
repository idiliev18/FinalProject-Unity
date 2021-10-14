using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnlockAchievementAtColision : MonoBehaviour
{
    public AchievementsManager achievementsManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (this.gameObject.name == "Colission Area Toilet")
            {
                achievementsManager.unlockAchievement(achievementsManager.adventureAchievement);
            }
            else
            {
                StartCoroutine(Wait());
                achievementsManager.unlockAchievement(achievementsManager.dejaVuAchievement);
            }
        }
    }

    IEnumerator Wait()
    {
        Debug.Log("Start");
        yield return new WaitForSecondsRealtime(3f);
        Debug.Log("Stop");
        Application.LoadLevel(Application.loadedLevel);
    }
}
