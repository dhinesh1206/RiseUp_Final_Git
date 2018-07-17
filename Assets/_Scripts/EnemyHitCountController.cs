using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitCountController : MonoBehaviour {

    public int hitCount;
    TextMesh tm;

	// Use this for initialization
	void Start () {
        tm = GetComponentInChildren<TextMesh>();
        tm.text = hitCount.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            if (hitCount == 0)
            {
                Destroy(gameObject);
            }
            else
            {
                hitCount -= 1;
                tm.text = hitCount.ToString();
            }
        }
    }
}
