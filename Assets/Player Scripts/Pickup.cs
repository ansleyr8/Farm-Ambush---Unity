using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int pickupNum = 1;
   int  increment = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        increment++;
        transform.rotation=Quaternion.Euler(new Vector3(0,increment,0)/3);
    }
    private void OnTriggerEnter(Collider col){
        if(col.gameObject.tag=="Player"){
            GameObject.FindWithTag("Player").AddComponent<FireSecondaryB>();
            
            
             Destroy(GameObject.FindWithTag("pickup"+pickupNum));
        }
    }
}
