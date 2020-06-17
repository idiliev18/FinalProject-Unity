using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialoguTrigger : MonoBehaviour
{
    /*
    public Dialogue dialogue;
    public DialogueManager dialogueManager;
    public FixedButton fixedButton;

    public Image buttton;

    public Color yellow;

    public TextMeshProUGUI AText;

    PlayerControl controls;

    void Awake()
    {
        controls = new PlayerControl();
    }

    void OnTriggerEnter2D(Collider2D collision)
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
                
            if (fixedButton.Pressed || controls.Gameplay.Attack.triggered)
            {
                dialogueManager.StartDialogue(dialogue);
            }
        }
    }

    void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    void OnDisable()
    {
        controls.Gameplay.Disable();
    }
    */
}
