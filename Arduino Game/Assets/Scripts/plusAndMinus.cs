using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plusAndMinus : MonoBehaviour
{
    public bool plus;
    public bool minus;

    public GameObject enterHint;

    void Update()
    {
        if (plus & minus)
        {
            if (enterHint != null)
            {
                enterHint.SetActive(true);
            }
        }
        else
        {
             if (enterHint != null)
            {
                enterHint.SetActive(false);
            }
        }
    }
}
