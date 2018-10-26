using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipController : MonoBehaviour{

    public Rigidbody2D rb;
    public float moveSpeed;
    private Vector2 moveInput;
    private Vector2 moveVelocity;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 5f;

    }

    // Update is called once per frame
    void Update()
    {
            
        if (transform.position.x > 8){

            transform.position = new Vector3(-8, transform.position.y, 0);
        }else if (transform.position.x < -8){
            transform.position = new Vector3(8, transform.position.y, 0);
        }else if (transform.position.y > 6){
            transform.position = new Vector3(transform.position.x, -6, 0);
        }else if (transform.position.y < -6){
            transform.position = new Vector3(transform.position.x, 6, 0);
        }

        Vector3 pmouse = Input.mousePosition;
        pmouse = Camera.main.ScreenToWorldPoint(pmouse);

        Vector2 direction = new Vector2(pmouse.x - transform.position.x, pmouse.y - transform.position.y);

        transform.up = direction;

       
    }




   



}