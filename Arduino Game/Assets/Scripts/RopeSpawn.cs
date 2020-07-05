using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeSpawn : MonoBehaviour
{
    [SerializeField]
    GameObject partPrefab;
    [SerializeField]
    GameObject parentObjects;

    [SerializeField]
    [Range(0.1f, 1000)]
    float length = 1;

    [SerializeField]
    float partDistance = 0.21f;

    [SerializeField]
    bool reset, spawn, snapFirst, snapLast;

    public Transform posFinal;

    // Update is called once per frame
    void Update()
    {
        if(reset)
        {
            foreach (GameObject tmp in GameObject.FindGameObjectsWithTag("Player"))
            {
                Destroy(tmp);
            }
            foreach (GameObject tmp in GameObject.FindGameObjectsWithTag("Player1"))
            {
                Destroy(tmp);
            }

            reset = false;
        }

        if (spawn)
        {
            spawn = false;
            
            Spawn();
        }
    }

    public void Spawn()
    {
        int count = (int)(length / partDistance);

        for (int x = 0; x < count; x++)
        {
            GameObject tmp;

            tmp = Instantiate(partPrefab, new Vector3(transform.position.x, transform.position.y + partDistance * (x + 1), transform.position.z), Quaternion.identity, parentObjects.transform);
            tmp.transform.eulerAngles = new Vector3(180, 0, 0);

            tmp.name = parentObjects.transform.childCount.ToString();

            if (x == 0)
            {
                Destroy(tmp.GetComponent<CharacterJoint>());
                if (snapFirst)
                {
                    tmp.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                    tmp.tag = "Rope1";
                    tmp.GetComponent<CapsuleCollider>().isTrigger = true;
                }
            }
            else
            {
                tmp.GetComponent<CharacterJoint>().connectedBody = parentObjects.transform.Find((parentObjects.transform.childCount - 1).ToString()).GetComponent<Rigidbody>();
            }
        }

        if (snapLast)
        {
            parentObjects.transform.Find(parentObjects.transform.childCount.ToString()).GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            parentObjects.transform.Find(parentObjects.transform.childCount.ToString()).GetComponent<CapsuleCollider>().isTrigger = true;
            parentObjects.transform.Find(parentObjects.transform.childCount.ToString()).tag = "Rope1";
            parentObjects.transform.Find(parentObjects.transform.childCount.ToString()).transform.position = posFinal.transform.position;
        }
    }
}
