using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinScript : MonoBehaviour
{
    public GameObject LEDLight;

    public plusAndMinus plusAndMinus;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pin+"))
        {
            plusAndMinus.plus = true;
        }

        if (other.gameObject.CompareTag("Pin-"))
        {
            plusAndMinus.minus = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Pin+"))
        {
            plusAndMinus.plus = false;
        }

        if (other.gameObject.CompareTag("Pin+"))
        {
            plusAndMinus.minus = false;
        }
    }

    public void Test()
    {
        if (plusAndMinus.plus == true && plusAndMinus.minus == true)
        {
            LEDLight.SetActive(true);
        }
    }
}
