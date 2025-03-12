using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float health, maxHealth =3f;
    public static Transform target;
    Rigidbody rb;
    [SerializeField]
    public float speed = 5.0f; //rotation speed
    private bool rotate = false;
    [SerializeField]
    // Floating_HealthBar healthBar;



    // Start is called before the first frame update
    void Start()
    {
        target =GetComponent<Transform>();
        health = maxHealth;
        // healthBar.UpdateHealthBar(health,maxHealth);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            rotate = !rotate; //toggle rotation
        }

        if (rotate)
        {
            RotateWithMouse();
        }
        
    }

    

    void RotateWithMouse()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.transform.position.y;
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector3 direction = worldPos - transform.position;
        direction.y = 0; // keep rotation on the Y-axis only

        if (direction.sqrMagnitude > 0.0f) // if direction is not zero
        {
            Quaternion toRotation = Quaternion.LookRotation(direction, Vector3.up);
            transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, speed * Time.deltaTime);
        }


    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        // healthBar = GetComponentInChildren<Floating_HealthBar>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the collided object is an enemy
        if (other.gameObject.CompareTag("_enemy"))
        {
            TakeDamage(1); // take 1 damage
        }
    }

    public void TakeDamage(float damageAmount)
    {
        // health -= damageAmount;
        // // healthBar.UpdateHealthBar(health, maxHealth);
        // if (health <= 0)
        // {
        //     Die();
        // }
    }

    void Die()
    {
        Debug.Log("Player has been destroyed");
        Destroy(this.gameObject);
    }


    
}
