using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class teacherControler : MonoBehaviour
{
    public Transform player;
    public Vector3 target;
    public NavMeshAgent agent;

    void Update()
    {
        target = player.position;

        agent.SetDestination(target);
    }
}
