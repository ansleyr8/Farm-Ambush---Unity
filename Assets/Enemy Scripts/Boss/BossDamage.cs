using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDamage : MonoBehaviour
{

  private bool isGrowing = false;
  private float growTime = 0;
    private float growScale = 0;
 
  private bool isShrinking = false;
  private bool timeLoop = false;
  private float time = 0;
  private float shrinkTime=0;
  private float shrinkScale;
  public static float maxHits =10;
    public static bool bossRespawn;
    int hits = 0;
    // Start is called before the first frame update
    void Start()
    {
         bossRespawn=false;
    }

    // Update is called once per frame
    void Update()
    {
      if(isGrowing){
      
       
          growScale = Mathf.Lerp(transform.parent.localScale.x,transform.parent.localScale.x+1,growTime/20);
          transform.parent.localScale =growScale*Vector3.one;
         growTime+=Time.deltaTime/10;
      
      }
      if(growScale>15){
        isGrowing=false;
      }
       if(isShrinking){
         BossAI.bossAppeared=false;
        if(shrinkTime>4){
            BossAI.bossAppeared=false;
          
           Destroy(transform.parent.gameObject);
           shrinkTime=0;
        }
        else{
         
          shrinkScale=Mathf.Lerp(transform.parent.localScale.x,0,shrinkTime/9);
          transform.parent.localScale=shrinkScale*Vector3.one;
          shrinkTime+=Time.deltaTime;
        }
       }
    }
    private void OnTriggerEnter(Collider col){
       if(col.gameObject.tag=="projectile"){
      hits++;
        
       }
       if(col.gameObject.tag=="Chicken"){
        isGrowing=true;
          Destroy(col.gameObject.transform.parent.gameObject);
          maxHits+=2;
        }
    }
    
     private void  OnTriggerStay(Collider col){
      


        float x=1;
        float y=1;
        float z=1;
        time += Time.fixedDeltaTime;
       
       
        Debug.Log("this is a test");
          if(col.gameObject.tag=="BigBarrel"&&GrowingBarrel.barrelStrike&&BarrelStartArea.leftArea){
           
            Debug.Log("done");
           
            maxHits=6;
              isShrinking=true;
            
             Destroy(col.transform.parent.gameObject);
             time = 0;
             transform.gameObject.tag ="defeated";
             transform.parent.gameObject.tag="defeated";
            
           
            }
        if(col.gameObject.tag=="bowling"&&Projectile.projectileExit){
          
           if(hits == maxHits){
            
           
           isShrinking=true;
             maxHits=6;
            bossRespawn=true;
            transform.gameObject.tag ="defeated";
            transform.parent.gameObject.tag="defeated";
            hits = 0;
           }
             
        }
        if(col.gameObject.tag=="projectile"&&Projectile.projectileExit){
          Destroy(col.gameObject);
            Debug.Log("This is the tag of the projectile, "+col.gameObject.tag);
           
           if(hits==maxHits){
           
            
            
            isShrinking=true;
             maxHits=6;
             
             bossRespawn =true;
             transform.gameObject.tag ="defeated";
             transform.parent.gameObject.tag="defeated";
             hits=0;
           }

            
        }
    }
}
