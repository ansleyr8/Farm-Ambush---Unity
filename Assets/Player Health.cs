using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    bool startDecrease = false;
   public Slider slider;
   private float fillLerp=0;
   private float fillDamage = 0;
   private float time = 0;
   private bool startTimer = false;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if(startDecrease){
         fillLerp =Mathf.Lerp(1,0,fillDamage/8);
        fillDamage+=Time.deltaTime;
        slider.value=fillLerp;
        }
        if(slider.value == 0){
            SceneManager.LoadScene("Lose");
        }
        
    }
    private void OnTriggerStay(Collider col){
       
      

        if(col.gameObject.tag!="defeated"&&(col.gameObject.tag=="Boss"||col.gameObject.tag=="_enemy")){
          startDecrease=true;
       Debug.Log(fillLerp);
        
        }
    }
     private void OnTriggerExit(Collider col){
        startDecrease = false;
     }
   
}
