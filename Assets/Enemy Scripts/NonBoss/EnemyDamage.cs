using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
   float shrinkDuration =4;
    bool playOnce=true;
    public AudioSource src;
    public AudioClip clip;
     public AudioClip clip2;
      public AudioClip clip3;
       public AudioClip clip4;
    public static int wantedNum=0;
    public string wantedAnimal="";
    float shrinkScale=0;
    bool isShrinking=false;
    float shrinkTime =0;
    public static int respawn;
    public static Transform boss;
    float rng=0;
       int rng2=0;
    
    // Start is called before the first frame update
    void Start()
    {
        boss = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
     
            if(FavoritePlaces.enemyWipe){
            isShrinking=true;
        }
        if(isShrinking){
            if(shrinkTime>shrinkDuration){
                 
                Destroy(transform.parent.gameObject);
                shrinkTime=0;
               
            }
            else{
                
                shrinkScale = Mathf.Lerp(transform.parent.localScale.x,0.5f,shrinkTime/shrinkDuration);
                shrinkTime+=Time.deltaTime;
                transform.parent.localScale=shrinkScale*Vector3.one;
                
            }
        }
    }
     private void  OnTriggerEnter(Collider col){
        if(wantedAnimal == FavoritePlaces.wanted&&col.gameObject.tag=="projectile"){
                wantedNum+=1;
                wantedAnimal = "defeated";
                if(wantedNum>FavoritePlaces.num){
                    FavoritePlaces.metAmount = true;
                }
                }
        rng= Random.Range(1,4.4f);
       rng2=Mathf.RoundToInt(rng);
       
        if(rng2==4){
            src.clip=clip4;
        }
        if(rng2==3){
            src.clip=clip3;
        }
        if(rng2==2){
            src.clip=clip2;
        }
        if(rng2==1){
            src.clip=clip;
        }
         if(col.gameObject.tag=="projectile"||col.gameObject.tag=="bowling"){
    // src.Play();
        }
     }
    private void  OnTriggerStay(Collider col){
       
        float x=1;
        float y=1;
        float z=1;
        Debug.Log("this is a test");
        if(col.gameObject.tag=="bowling"){
          if(playOnce == true){
           
                
                playOnce=false;
          }
          isShrinking=true;
            respawn++;
            
            transform.gameObject.tag ="defeated";
            transform.parent.gameObject.tag="defeated";
        }
        if(col.gameObject.tag=="projectile"){
           
            Debug.Log("This is the tag of the projectile, "+col.gameObject.tag);
             if(playOnce == true){
           
                
                playOnce=false;
             }
             isShrinking=true;
             Destroy(GameObject.FindWithTag("projectile"));
            respawn++;
            transform.gameObject.tag ="defeated";
            transform.parent.gameObject.tag="defeated";
        }
    }
}
