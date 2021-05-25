using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialoguTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public DialogueManager dialogueManager;
    public AudioSource audioSource;

    bool firstTime = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!firstTime)
        {
            dialogueManager.StartDialogue(dialogue);
            firstTime = true;
            audioSource.Play();
        }
    }
}
