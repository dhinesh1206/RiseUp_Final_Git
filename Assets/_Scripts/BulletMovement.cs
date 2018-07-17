using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    Rigidbody2D rb;
    public float speedMultiplier;

	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 2f);
	}
	
	void Update ()
    {
        rb.AddForce(new Vector2(0, 1) * speedMultiplier,ForceMode2D.Impulse);	
	}

   
}
