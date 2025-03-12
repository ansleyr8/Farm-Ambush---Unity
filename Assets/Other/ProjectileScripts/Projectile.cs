using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Projectile : MonoBehaviour
{
    public AudioSource src;
    public AudioClip clip;
    public AudioClip clip2;
    public AudioClip clip3;
    public AudioClip clip4;
    float rng = 0;
    int rng2 = 0;
    public Rigidbody rb ;
    public string projectile ="standard";
    float speed=0;
    Transform transformPlayer;
    int increment=0;
    float positionx = 0;
    public float s;
    public static bool projectileExit=true;
    // Start is called before the first frame update
    void Start()
    {
          rng =Random.Range(1,4.4f);
        rng2 = Mathf.RoundToInt(rng);
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
        src.Play(0);
        rb = GetComponent<Rigidbody>();
      speed=0.5f;
      s=Mathf.RoundToInt(speed);
           transformPlayer =GameObject.Find("Player").GetComponent<Transform>();
             
             transform.parent=null;
    }
    void LateUpdate(){
        rb.velocity = new Vector3(-180,0,0);
        //  speed++;
        //    transform.Translate(new Vector3(transformPlayer.forward.x-speed,transformPlayer.forward.y,transformPlayer.forward.z) ); 
    }
    // Update is called once per frame
    void Update()
    {
      
projectileExit=true;
        increment++;
       positionx=transform.position.x;
       
      
        
    }
    private void  OnTriggerExit(Collider col){
        
        if(col.gameObject.tag=="colliderP"){
            Debug.Log("it indeed worked");
                
        }
    
   
         if(col.gameObject.tag=="colliderP")
        
        if(projectile=="fruit"){
            if(col.gameObject.name=="BCollider"){
               col.gameObject.GetComponent<GrowingBarrel>().enabled =true;
            
            }
        }
    }
    
}
