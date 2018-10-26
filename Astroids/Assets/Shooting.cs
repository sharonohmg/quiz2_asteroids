using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{     public GameObject bullet;
    public float speed;
    public float bulletForce;
    public Rigidbody2D rb;

    void Start()
    {
        speed = 5f;
        rb = GetComponent<Rigidbody2D>();
        bulletForce = 10f;
    }      void Update()     {         if (Input.GetButtonDown("Fire1"))
        {
            GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation);

            newBullet.GetComponent<Rigidbody2D>().AddRelativeForce(transform.up * 400f);

            Destroy(newBullet, 2f);

        }
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
    
        if (hit.gameObject.tag != "Bullet"){
     
            transform.position = new Vector3(0, 0, 0);

            GetComponent<Rigidbody2D>().
                velocity = new Vector3(0, 0, 0);                             
        } 
    }

  
}

   