using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchWeapon : MonoBehaviour
{
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("space")){
        Instantiate(projectile,transform.position,Quaternion.Euler(0,0,0),transform);
        }
    }
}
