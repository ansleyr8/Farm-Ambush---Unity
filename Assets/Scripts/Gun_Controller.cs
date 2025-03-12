using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Controller : MonoBehaviour
{
    public bool isFiring;

    public Bullet_Controller bullet;
    public float bulletSpeed;

    public float cool_down;
    private float shotCounter;

    public Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isFiring)
        {
            shotCounter -= Time.deltaTime;
            if(shotCounter <= 0)
            {
                shotCounter = cool_down;
                Bullet_Controller newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as Bullet_Controller;
                newBullet.speed =  bulletSpeed;
            }
            else
            {
                shotCounter = 0;
            }
        }   
        
    }
}
