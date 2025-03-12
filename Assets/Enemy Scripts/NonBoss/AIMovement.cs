using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMovement : MonoBehaviour
{
    private bool _stopSpawning = false;
   bool ground;
    Transform target ;
    NavMeshAgent agent;



    void Start(){
        
       agent = GetComponent<NavMeshAgent>();
          if(GetComponent<NavMeshAgent>()!=null)
            target = GameObject.Find("Player").transform;
     
    }

    void Update(){
        if(ground=true)
        agent.destination=target.position;
    }
    private void OnTriggerEnter(Collider other) {
        ground = true;
    }
}
