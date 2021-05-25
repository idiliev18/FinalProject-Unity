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
            enterHint.SetActive(true);
        }
        else
        {
            enterHint.SetActive(false);
        }
    }
}
