using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class RandomMove : MonoBehaviour
{

    private NavMeshAgent _agent;
    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(_agent.destination, transform.position)  < 3f)
        {
            float randomX = Random.Range(0f, 10f);
            float randomZ = Random.Range(0f, 10f);
            Vector3 randomPos = new Vector3(randomX, transform.position.y, randomZ);
            _agent.destination = randomPos;
        }
    }
}
