using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class TutorialBarrel2 : MonoBehaviour
{
   
     public TMP_Text txt;
    public GameObject image ;
    public bool start = false;
    public float time = 0;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
         if(start)
         time+=Time.deltaTime;
       
        if(time>2){
            SceneManager.LoadScene("Instructions");
        }
    }
     private void  OnTriggerEnter(Collider col){
        if(col.gameObject.tag=="Fruit"){
            start=true;
            Destroy(col.gameObject);
          
            txt.SetText("<color=green>Press C to fire fruit(WhenScore=10).");

        
           
        }
     }
}
