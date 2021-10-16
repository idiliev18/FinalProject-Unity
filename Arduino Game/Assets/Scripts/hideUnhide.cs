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
        if (Input.GetKeyDown(KeyCode.E))
        {
            unhideObject.SetActive(true);
            gameObject.SetActive(false);
            if (button != null)
            {
                button.SetActive(true);
            }
        }
    }
}
