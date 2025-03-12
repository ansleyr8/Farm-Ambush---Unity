using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPoint : MonoBehaviour
{   
    public Scoring score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    private void OnTriggerEnter(Collider col){
        if(col.gameObject.tag=="projectile"&& this.gameObject.tag!="defeated") {
           
            score.AddScore(1);
            score.UpdateScore();
        }
    }
}
