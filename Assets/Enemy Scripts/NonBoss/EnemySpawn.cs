using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Unity.AI.Navigation;
public class EnemySpawn : MonoBehaviour
{
   public int spawnLimit = 0;
    bool limitbossRespawn=false;
    public int enemyTime =3;
    public int bossTime =3;
   bool allowSpawn = true;
    public  string spawnerType="";
    public Transform target;
    public GameObject enemyToSpawn;
    private float time=0;
    private float spawnTimer=0;
    private int arrayNum=0;
    GameObject obj;
    public int limit = 0;
    NavMeshAgent agent;
    GameObject [] enemyArray = new GameObject[4];
    NavMeshAgent [] agentArray = new NavMeshAgent[4];
    float allowSpawnTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
      
           
                if(spawnerType=="enemy"){
                    for(int i =0;i<limit;i++){
                    enemyArray[i]= Instantiate(enemyToSpawn, transform.position,Quaternion.Euler(0,0,0),transform);
                    enemyArray[i].SetActive(true);
                    
                    }
                }
             
        
       
         
        //    player = GameObject.Find("Player").GetComponent<Transform>();
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
        spawnTimer+=Time.deltaTime;
        if(spawnTimer<enemyTime&&!BossAI.bossAppeared&&spawnerType=="boss"){
            BossDamage.bossRespawn=true;
            spawnTimer+=Time.deltaTime;
        }
        else{
             BossDamage.bossRespawn=false;
        }
        
            if(spawnerType == "enemy"&&spawnTimer>enemyTime){
                spawnLimit++;
                for(int i =0;i<limit;i++){
                    
                        enemyArray[i]= Instantiate(enemyToSpawn, transform.position,Quaternion.Euler(0,0,0),transform);
                        enemyArray[i].SetActive(true);
                    
                    }
                    spawnTimer=0;
                    spawnLimit=0;

            }
        
        // if(spawnerType == "enemy"){
        //     if(spawnTimer>enemyTime){
             
               
           
              
            
        //     if(EnemyDamage.respawn>=limit*4){
        //         for(int i =0;i<limit;i++){
                   
        //             enemyArray[i]= Instantiate(enemyToSpawn, transform.position,Quaternion.Euler(0,0,0),transform);
        //             enemyArray[i].SetActive(true);
                 
        //         }
        //          EnemyDamage.respawn=0;
        //          spawnTimer=0;
        //     }
             
               
            
        //     }
        // }
        if(spawnerType == "boss"){
        if(spawnTimer>bossTime&&!limitbossRespawn){
            spawnTimer=0;
         limitbossRespawn=true;
            
                    for(int i =0;i<limit;i++){
                    enemyArray[i]= Instantiate(enemyToSpawn, transform.position,Quaternion.Euler(0,0,0),transform);
                    enemyArray[i].SetActive(true);
                    
                    }
           
           
            
             spawnTimer=0;
        }
        }
        
        // for(int i =0;i<enemyArray.Length;i++){
        //    agent =  enemyArray[i].GetComponent<NavMeshAgent>();
        //    agent.destination = player.position;
        // }
        // time +=Time.deltaTime;
        // if(time>1&&firstEnemy&&limit<4){

            
        //    agentArray[limit].destination = player.position;
        //    if(limit<4)
        //     limit++;
           
           
        //      time = 0;
        //      firstEnemy = false;
        //      instantiated = true;
        // }
        // if(time>3&&limit<4&&!firstEnemy){

        //     enemyArray[limit] =Instantiate(enemyToSpawn, transform.position,Quaternion.Euler(0,0,0),transform);
        //  for(int i =0;i<agentArray.Length;i++){
        //     agentArray[i].destination = player.position;
        // }
        
            
        //     if(limit<4)

        //     limit++;
           
            
        //      time = 0;
        // }

    

        

       
            
        
    }
}
