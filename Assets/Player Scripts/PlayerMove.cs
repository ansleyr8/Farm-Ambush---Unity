using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyUp("up")){
            anim.SetBool("isRunning", false);
        }
        if(Input.GetKeyUp("right")){
            
            anim.SetBool("isRunning",false);
        }
        if(Input.GetKeyUp("left")){
            
            anim.SetBool("isRunning",false);
        }
        if(Input.GetKeyUp("down")){
            
            anim.SetBool("isRunning",false);
        }
          if(Input.GetKeyUp("w")){
            anim.SetBool("isRunning", false);
        }
        if(Input.GetKeyUp("a")){
            
            anim.SetBool("isRunning",false);
        }
        if(Input.GetKeyUp("s")){
            
            anim.SetBool("isRunning",false);
        }
        if(Input.GetKeyUp("d")){
            
            anim.SetBool("isRunning",false);
        }
        
          
       if(Input.GetKey("up")){
        
        Up();
       
        
       }
       if(Input.GetKey("right")){
      
        Right();
       }
       if(Input.GetKey("left")){
       
        Left();
        
       }
       if(Input.GetKey("down")){
       
        Down();
       
       
       }
        if(Input.GetKey("w")){
        
        W();
       
        
       }
       if(Input.GetKey("a")){
      
        A();
       }
       if(Input.GetKey("s")){
       
        S();
        
       }
       if(Input.GetKey("d")){
       
        D();
       
       
       }
      
        
    }
    private void Up(){
          if(Input.GetKey("up")){
            transform.Translate(Vector3.forward*Time.deltaTime*20);
            anim.SetBool("isRunning",true);
        }
    }
    private void Right(){
         if(Input.GetKey("right")){
            transform.Translate(Vector3.right*Time.deltaTime*30);
            anim.SetBool("isRunning",true);
        }
    }
      private void Left(){
         if(Input.GetKey("left")){
            transform.Translate(Vector3.left*Time.deltaTime*30);
            anim.SetBool("isRunning",true);
        }
    }
      private void Down(){
          if(Input.GetKey("down")){
            transform.Translate(Vector3.back*Time.deltaTime*30);
            anim.SetBool("isRunning",true);
        }
    }
     private void W(){
          if(Input.GetKey("w")){
            transform.Translate(Vector3.forward*Time.deltaTime*20);
            anim.SetBool("isRunning",true);
        }
    }
    private void S(){
         if(Input.GetKey("s")){
            transform.Translate(Vector3.back*Time.deltaTime*30);
            anim.SetBool("isRunning",true);
        }
    }
      private void A(){
         if(Input.GetKey("a")){
            transform.Translate(Vector3.left*Time.deltaTime*30);
            anim.SetBool("isRunning",true);
        }
    }
      private void D(){
          if(Input.GetKey("d")){
            transform.Translate(Vector3.right*Time.deltaTime*30);
            anim.SetBool("isRunning",true);
        }
    }
 private void UpHalfSpeed(){
          if(Input.GetKey("up")){
            transform.Translate(Vector3.forward*Time.deltaTime*10f);
            anim.SetBool("isRunning",true);
        }
    }
    private void RightHalfSpeed(){
         if(Input.GetKey("right")){
            transform.Translate(Vector3.right*Time.deltaTime*10f);
            anim.SetBool("isRunning",true);
        }
    }
      private void LeftHalfSpeed(){
         if(Input.GetKey("left")){
            transform.Translate(Vector3.left*Time.deltaTime*10f);
            anim.SetBool("isRunning",true);
        }
    }
      private void DownHalfSpeed(){
          if(Input.GetKey("down")){
            transform.Translate(Vector3.back*Time.deltaTime*5f);
            anim.SetBool("isRunning",true);
        }
    }

}

