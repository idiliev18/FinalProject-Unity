using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class teacherControler : MonoBehaviour
{
    Vector3 oldPosition;
    public Animator animator;
    public float speed;
    public Transform destination;
    public Vector3 target;
    public NavMeshAgent agent;

    void Update()
    {
        target = destination.position;

        agent.SetDestination(target);

        speed = Vector3.Distance(oldPosition, transform.position);
        oldPosition = transform.position;

        animator.SetFloat("MoveSpeed", speed);
    }
}
