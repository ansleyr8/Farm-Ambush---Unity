using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateHoming : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col){
        if(col.gameObject.name=="Fruit")
        transform.parent.gameObject.GetComponent<GrowingBarrel>().enabled=true;
    }
}
