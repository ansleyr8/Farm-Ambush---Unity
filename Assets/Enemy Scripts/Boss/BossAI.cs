using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class BossAI : MonoBehaviour
{
  public AudioSource src;
    private bool _stopSpawning = false;
   public static bool bossAppeared=false;
    Transform target ;
    NavMeshAgent agent;



    void Start(){
        src.Play(0);
        target = GameObject.Find("Player").GetComponent<Transform>();
       agent = GetComponent<NavMeshAgent>();
       bossAppeared=true;
       Debug.Log("appeared");
     
    }

    void Update(){
        agent.destination=target.position;
    }


}
