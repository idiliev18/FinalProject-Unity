using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRope : MonoBehaviour
{
    public RopeSpawn ropeSpawn;

    public void OnMouseDown()
    {
        ropeSpawn.Spawn();
    }
}
