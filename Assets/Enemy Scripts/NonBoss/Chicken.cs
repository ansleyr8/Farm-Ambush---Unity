using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chicken : MonoBehaviour
{
       Transform target ;
       Transform target2 ;
    NavMeshAgent agent;
    // Start is called before the first frame update
 void Start(){
    
        
            agent = GetComponent<NavMeshAgent>();
                target2 = GameObject.FindWithTag("Player").transform;
        }
            
        



    void Update(){
        Debug.Log("PARENT"+GameObject.FindWithTag("BossParent"));
        if(GameObject.Find("BossParent(Clone)")!=true){
        agent.destination=target2.position;
        }
        if(GameObject.Find("BossParent(Clone)")){
            if(BossAI.bossAppeared&&GameObject.Find("BossParent"))
              target = GameObject.FindWithTag("BossParent").transform;
              if(BossAI.bossAppeared&&GameObject.Find("BossParent"))
            agent.destination=target.position;
        }
    }
}
