using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialoguTrigger : MonoBehaviour
{
    
    public Dialogue dialogue;
    public DialogueManager dialogueManager;

    public Image buttton;

    public Color yellow;

    public TextMeshProUGUI AText;

    void OnTriggerEnter(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            dialogueManager.show = true;
            AText.text = "Interact";
            buttton.color = yellow;
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            dialogueManager.show = true;
                
            if (true)
            {
                dialogueManager.StartDialogue(dialogue);
            }
        }
    }
}
