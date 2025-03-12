using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLerp : MonoBehaviour
{
    public GameObject Player;
    private float lerpX =0f;
    private float lerpXNegative =0f;
    private float lerpZ =0f;
     private float lerpZNegative = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        lerpX= Mathf.Lerp(transform.position.x, Player.transform.position.x,0);
        lerpXNegative= -Mathf.Lerp(Player.transform.position.x, transform.position.x,0);
        lerpZ= Mathf.Lerp(transform.position.z, Player.transform.position.z,0);
        lerpZNegative= -Mathf.Lerp(transform.position.z, Player.transform.position.z,0);
        
        transform.position = Vector3.Lerp(new Vector3(transform.position.x, transform.position.y, transform.position.z), new Vector3(Player.transform.position.x,transform.position.y , Player.transform.position.z),25 * Time.deltaTime);
        
    }
}
