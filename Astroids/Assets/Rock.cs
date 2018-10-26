using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour {

    public float move;
    public Rigidbody2D rb;

    // Use this for initialization
    void Start () {
        Vector2 movement = new Vector2(Random.Range(-move, move), Random.Range(-move, move));

        rb.AddForce(movement);

    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > 8){

            transform.position = new Vector3(-8, transform.position.y, 0);
        }else if (transform.position.x < -8){
            transform.position = new Vector3(8, transform.position.y, 0);
        }else if (transform.position.y > 6){
            transform.position = new Vector3(transform.position.x, -6, 0);
        }else if (transform.position.y < -6){
            transform.position = new Vector3(transform.position.x, 6, 0);
        }

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
          
                Destroy(gameObject);
        }
    }
}
