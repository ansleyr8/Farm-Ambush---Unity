using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyProperties : MonoBehaviour
{   
    Transform target ;
    public static NavMeshAgent agent;
    void Start(){
        target = GameObject.Find("Player").GetComponent<Transform>();
       agent = GetComponent<NavMeshAgent>();
     
    }

    // Update is called once per frame
    void Update()
    {
        
           agent.destination = target.position;
        
    }
}
