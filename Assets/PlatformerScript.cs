using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class PlatformerScript : MonoBehaviour
{

    public NavMeshAgent agent;

    public GameObject end;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = end.transform.position;
    }
}
