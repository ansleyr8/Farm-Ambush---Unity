using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class GrowingBarrel : MonoBehaviour
{
    public static NavMeshAgent agent;
    public static bool barrelStrike=false;
     int  increment = 0;
    float time = 0;
    bool startTimer=false;

    bool startMovement=false;

    void Start(){
        agent =   this.transform.parent.GetComponent<NavMeshAgent>();
       
    }

    

    // Update is called once per frame
    
    void Update()
    {
        if(startTimer)
         time += Time.deltaTime;
         increment++;
          this.transform.parent.rotation=Quaternion.Euler(new Vector3(0,increment,0)/3);
      
       Debug.Log(barrelStrike);
       Debug.Log(startMovement);
       
    
       

    }
     private void OnTriggerEnter(Collider col){
         if(col.gameObject.tag=="Fruit"&& barrelStrike){

            Destroy(this.transform.parent);
            }
            
        // if(col.gameObject.tag=="Boss"){
        //     startTimer=true;
        //     if(time>3){
        //     Destroy(GameObject.FindWithTag("BossParent"));
        //    Destroy(GameObject.Find("BigBarrelParent"));
        //     }
        // }
        
           
        
        Debug.Log("fruit");
        if(col.gameObject.tag=="Fruit"){
            Debug.Log("fruit");
             this.transform.parent.localScale = new Vector3( this.transform.parent.localScale.x+15, this.transform.parent.localScale.y+15, this.transform.parent.localScale.z+15);
           if( this.transform.parent.localScale.x>37){
           
            barrelStrike=true;
             Destroy(GameObject.FindWithTag("Fruit"));
           }
        }
    }
}
