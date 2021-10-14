using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pinScript : MonoBehaviour
{
    public GameObject LEDLight;

    public plusAndMinus plusAndMinus;

    public int level = 2;

    public Dialogue dialogue;
    public DialogueManager dialogueManager;
    public AudioSource audioSource;
    
    public Dialogue dialogue2;
    public DialogueManager dialogueManager2;
    public AudioSource audioSource2;

    public AchievementsManager achievementsManager;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter"); 
        if (other.gameObject.CompareTag("Pin+"))
        {
            plusAndMinus.plus = true;
        }

        if (other.gameObject.CompareTag("Pin-"))
        {
            plusAndMinus.minus = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");  
        if (other.gameObject.CompareTag("Pin+"))
        {
            plusAndMinus.plus = false;
        }

        if (other.gameObject.CompareTag("Pin+"))
        {
            plusAndMinus.minus = false;
        }
    }

    public void Test()
    {
        if (plusAndMinus.plus == true && plusAndMinus.minus == true)
        {
            if (achievementsManager != null)
            {
                if (SceneManager.GetActiveScene().buildIndex == 1)
                {
                    achievementsManager.unlockAchievement(achievementsManager.theStartAchievement);
                } else 
                {
                    achievementsManager.unlockAchievement(achievementsManager.thePushAchievement);
                }
            }
            StartCoroutine(Wait());
            LEDLight.SetActive(true);
            dialogueManager.StartDialogue(dialogue);
            audioSource.Play();
        }
        else
        {
            dialogueManager.StartDialogue(dialogue2); 
            audioSource2.Play();
        }
    }

    IEnumerator Wait()
    {
        Debug.Log("Start");
        yield return new WaitForSecondsRealtime(10);
        Debug.Log("Stop");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        level = SceneManager.GetActiveScene().buildIndex + 1;
        SaveSystem.SaveData(this);
    }
}

