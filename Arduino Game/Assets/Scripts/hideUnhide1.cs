using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class hideUnhide1 : MonoBehaviour
{
    public GameObject unhideObject;

    public GameObject hint;

    void OnMouseOver()
    {
        hint.SetActive(true);

        if (Input.GetKeyDown(KeyCode.E))
        {
            unhideObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }
    
    void OnMouseExit()
    {
        hint.SetActive(false);
    }
}
