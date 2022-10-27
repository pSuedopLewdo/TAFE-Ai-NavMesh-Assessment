using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AreaMovementModifier : MonoBehaviour
{

    private NavMeshAgent _agent;
    [SerializeField] private float regSpeed = 10f;
    [SerializeField] private float slowSpeed = 5f;
    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        NavMeshHit hit;
        _agent.SamplePathPosition(-1, 0, out hit);
        int grassMask = 1 << NavMesh.GetAreaFromName("TallGrass");
        int filtered = hit.mask & grassMask;

        if (filtered == 0)
        {
            _agent.speed = regSpeed;
            
        }
        else if(filtered == 8)
        {
            _agent.speed = slowSpeed;
        }
        
        Debug.Log(hit.mask);
    }
}
