using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testButton : MonoBehaviour
{
    public pinScript pinScript;

    private void OnMouseDown()
    {
        pinScript.Test();
    }
}
