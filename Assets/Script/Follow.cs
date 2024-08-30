using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Follow : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject Pls;

    // Start is called before the first frame update
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Pls = GameObject.FindWithTag("Player");
        agent.destination = Pls.transform.position;
    }
}
