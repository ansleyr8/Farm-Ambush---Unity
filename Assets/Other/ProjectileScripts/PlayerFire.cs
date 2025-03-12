using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    
    
    bool left = false;
    float time =0 ;
    bool cooldown=true;
    public GameObject projectile;
    GameObject projectileToFire;
    bool instantiated = false;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Scoring.score%10==0&&Scoring.score!=0){
            GetComponent<PlayerFireFruit>().enabled=true;
           
        }
        if(PlayerFireFruit.fruitCount==2){
            GetComponent<PlayerFireFruit>().enabled=false;
            PlayerFireFruit.fruitCount=0;
            
        }
if(projectileToFire!=null){
                   projectileToFire.SetActive(true);
            }
          
            if(cooldown==false){
            
                time+=Time.deltaTime;
                if(time>.2){
                    time =0;
                cooldown = true;
            
                }
            }
          
          
        if(Input.GetKeyDown("space")){
            if(cooldown==true){
            projectileToFire=Instantiate(projectile,GameObject.Find("Player").GetComponent<Transform>().position,Quaternion.Euler(0,0,0),GameObject.Find("Player").GetComponent<Transform>());
            projectileToFire.transform.localScale=new Vector3(70f,70f,70f);
            projectileToFire.transform.position+= new Vector3(0,10,0);
            
           
            cooldown=false;
            }
            
        }
        
       
        
            
       
       
    }
   

}
