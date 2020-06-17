using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI nameText;

	public DialoguTrigger dialoguTrigger;

	public Animator animator;
	public Animator playerAnimator;

	private Queue<string> sentences;

	//PlayerControl controls;

	public Rigidbody2D player;
	public PlayerMovement playerMovement;

	public bool show = false;

	[Range (0.01f, 1f)]
	public float time;

	void Start()
	{
		sentences = new Queue<string>();
	}

	public void StartDialogue(Dialogue dialogue)
	{
		show = true;

		animator.SetBool("IsOpen", true);

		playerAnimator.SetFloat("speed", 0);

		player.simulated = false;
		playerMovement.enabled = false;
		dialoguTrigger.enabled = false;

		nameText.text = dialogue.name;

		sentences.Clear();

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence();
	}

	public void DisplayNextSentence()
	{
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}

		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
	}

	IEnumerator TypeSentence(string sentence)
	{
		dialogueText.text = "";

		char[] array = sentence.ToCharArray();

		for (int i = 0; i < array.Length; i++)
		{
			char letter = array[i];
			dialogueText.text += letter;
			yield return new WaitForSecondsRealtime(time);
		}
	}

	void EndDialogue()
	{
		animator.SetBool("IsOpen", false);
		playerMovement.enabled = true;
		dialoguTrigger.enabled = true;
		player.simulated = true;
		//show = false;
	}
}
