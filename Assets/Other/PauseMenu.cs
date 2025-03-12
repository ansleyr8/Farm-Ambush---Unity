using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
      public GameObject UIElements ;
    public GameObject PauseMenuObj ;
    MeshRenderer meshR;
    bool menuOpened = false;
    bool coolDown= false;
    bool displayMenu = false;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       menuSwitch();
       
    }
    void menuSwitch(){
         if(!PauseMenuObj.active){
            if(Input.GetKeyDown("escape")){
                displayMenu=true;
                Time.timeScale = 0;
                UIElements.SetActive(false);
            }

        }
         if(PauseMenuObj.active){
            if(Input.GetKeyDown("escape")){
                displayMenu=false;
                Time.timeScale = 1;
                UIElements.SetActive(true);
            }

        }
        if(displayMenu){
            PauseMenuObj.active = true;
        }
        else{
             PauseMenuObj.active=false;
        }
    }
}
