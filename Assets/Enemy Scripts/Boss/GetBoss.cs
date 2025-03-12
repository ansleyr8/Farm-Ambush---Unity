using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBoss : MonoBehaviour
{
    public static Transform t;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
     
             t = transform.GetComponent<Transform>();
        
    }
}
