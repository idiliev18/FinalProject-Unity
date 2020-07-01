using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class hideUnhide : MonoBehaviour
{
    public GameObject unhideObject;
    public GameObject button;

    void OnMouseOver()
    {
        Debug.Log("Error1");
        if (Input.GetKeyDown(KeyCode.E))
        {
            unhideObject.SetActive(true);
            gameObject.SetActive(false);
            button.SetActive(true);
        }
    }
}
