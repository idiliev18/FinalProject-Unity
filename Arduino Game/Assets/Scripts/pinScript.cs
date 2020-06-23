using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinScript : MonoBehaviour
{
    public GameObject LEDLight;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Rope"))
        {
            other.transform.position = transform.position;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Rope"))
        {
            other.transform.position = transform.position;
        }
    }

    public void Test()
    {
        if (true)
        {
            LEDLight.SetActive(true);
        }
    }
}
