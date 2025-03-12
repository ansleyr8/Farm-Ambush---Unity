using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class TutorialBarrel : MonoBehaviour
{
     public static float points=0;
    public TMP_Text scoreTextTutorial;
     public TMP_Text txt;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void  OnTriggerEnter(Collider col){
         
        if(col.gameObject.tag=="projectile"){

            Destroy(col.gameObject);
          points ++;
   
     scoreTextTutorial.SetText("Score: "+points);
             if(points>=10){

                txt.SetText("<color=green>Press space to shoot projectile.(x10)");
                GameObject.Find("Player").GetComponent<PlayerFireFruit>().enabled = true;
                 scoreTextTutorial.SetText("<color=green>Score: "+points);
                  SceneManager.LoadScene("Instructions");
             }
        }
     }
}
