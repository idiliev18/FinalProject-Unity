using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinScript : MonoBehaviour
{
    public bool plus;
    public bool minus;

    public GameObject light;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            other.transform.position = transform.position;
            plus = true;
            minus = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            other.transform.position = transform.position;
        }
    }

    public void Test()
    {
        if (plus && minus)
        {
            light.SetActive(true);
        }
        else
        {
            light.SetActive(false);
        }
    }
}
