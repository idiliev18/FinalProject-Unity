using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    float throwForce = 800;
    Vector3 objectPos;
    float distance;

    public bool canHold = true;
    public GameObject item;
    public GameObject tempParent;
    public bool isHolding = false;

    // Update is called once per frame
    void Update()
    {

        distance = Vector3.Distance(item.transform.position, tempParent.transform.position);

        if (distance >= 10f)
        {
            isHolding = false;
        }
        //Check if isholding
        if (isHolding == true)
        {
            item.GetComponent<Rigidbody>().velocity = Vector3.zero;
            item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            item.transform.SetParent(tempParent.transform);

            if (Input.GetMouseButtonDown(1))
            {
                item.GetComponent<Rigidbody>().AddForce(tempParent.transform.forward * throwForce);
                isHolding = false;
            }
        }
        else
        {
            objectPos = item.transform.position;
            item.transform.SetParent(null);
            item.GetComponent<Rigidbody>().useGravity = true;
            item.transform.position = objectPos;
        }
    }

    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isHolding == false)
            {
                if (distance <= 10f)
                {
                    isHolding = true;
                    item.GetComponent<Rigidbody>().useGravity = false;
                    item.GetComponent<Rigidbody>().detectCollisions = true;
                }
            }
            else 
            { 
                isHolding = false; 
            }
        }
    }


    void OnMouseExit()
    {
        if (isHolding == true)
        {
            isHolding = false;
        }
    }
}