using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public bool open = false;
    public Animator animator;
    public Animator animator2;

    public void OnMouseOver()
    {

        if (Input.GetKeyDown("e"))
        {
            if (open)
            {
                animator.SetTrigger("Close");
                animator2.SetTrigger("Close");
                open = false;
            }
            else
            {
                animator.SetTrigger("Open");
                animator2.SetTrigger("Open");
                open = true;
            }
        }
    }
}
