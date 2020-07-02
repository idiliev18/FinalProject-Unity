using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class counter : MonoBehaviour
{
    public int num = 0;
    public GameObject button;
    public Vector3 p;

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Arduino") || other.CompareTag("LED"))
        {
            p = other.transform.position;
            p.z = 0;

            if (other.transform.rotation.z == 180)
            {
                other.transform.position = p;
            }

            num++;
        }
    }

    public void Update()
    {
        if (num == 2)
        {
            button.SetActive(true);
        }
    }
}
