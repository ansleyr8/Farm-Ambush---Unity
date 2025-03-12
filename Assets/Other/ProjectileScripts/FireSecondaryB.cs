using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSecondaryB : GetProjectileB
{
    int cooldown=0;
    float time = 0;
    GameObject projectileToFire;
    bool instantiated = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("x")){
            if(cooldown==0){
            projectileToFire=Instantiate(projectile,GameObject.Find("CH_06").GetComponent<Transform>().position,Quaternion.Euler(0,0,0),GameObject.Find("Player").GetComponent<Transform>());
            projectileToFire.SetActive(true);
            projectileToFire.transform.localScale=new Vector3(3.5f,3.5f,3.5f);
            cooldown +=1;
            }
            
        }
         if(cooldown==1){
             projectileToFire=Instantiate(projectile,GameObject.Find("CH_06").GetComponent<Transform>().position,Quaternion.Euler(0,0,0),GameObject.Find("Player").GetComponent<Transform>());
            projectileToFire.SetActive(true);
            projectileToFire.transform.localScale=new Vector3(3.5f,3.5f,3.5f);
            cooldown+=1;
         }
        if(cooldown==2){
            time+=Time.deltaTime;
            if(time>3){
            cooldown = 0;
            time =0;
            }
        }
        
    }

}
