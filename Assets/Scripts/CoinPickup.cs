using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class CoinPickup : MonoBehaviour
{
    public GameObject end;
    public int coinsCollected;
    public GameObject wall;
    public GameObject[] coins;
    public NavMeshAgent agent;
    public GameObject target;

    private void Start()
    {
        coinsCollected = 0;
        coins = GameObject.FindGameObjectsWithTag("Coin");
        FindCoin();
    }

    private void FindCoin()
    {
        foreach (var coin in coins)
        {
            if (coins != null)
            {
                target = coin;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Coin")) return;
        coinsCollected++;
        target = null;
        Destroy(collision.rigidbody.gameObject);
    }

    private void Update()
    {
        if (target != null)
        {
            agent.destination = target.transform.position;
        }

        if (target == null)
        {
            FindCoin();
        }
        if (coinsCollected == 3)
        {
            DestroyWall();
        }
    }

    private void DestroyWall()
    {
        Destroy(wall);
    }
}
