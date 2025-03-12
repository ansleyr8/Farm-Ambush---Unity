using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFireFruit : MonoBehaviour
{
   public static int fruitCount =0;
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
        
        
        if(Input.GetKeyDown("c")){
            if(cooldown==true&&fruitCount<2){
                fruitCount++;
            projectileToFire=Instantiate(projectile,GameObject.Find("Player").GetComponent<Transform>().position,Quaternion.Euler(0,0,0),GameObject.Find("Player").GetComponent<Transform>());
            projectileToFire.SetActive(true);
            projectileToFire.transform.localScale=new Vector3(3.5f,3.5f,3.5f);
            cooldown=false;
            }
            
        }
        if(cooldown==false){
            time+=Time.deltaTime;
            if(time>3){
            cooldown = true;
            time =0;
            }
        }
       
    }
   
    
}
