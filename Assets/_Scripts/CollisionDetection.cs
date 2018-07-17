using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CollisionDetection : MonoBehaviour {

    
    float scaleValue,massValue;
    public float reducingRate,timeToResize,massToResize;
    public Ease easetype;


	// Use this for initialization
	void Start () {
        scaleValue = transform.localScale.x;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        if (collision.gameObject.tag == "Bullet")
        {
            massValue = gameObject.GetComponent<Rigidbody2D>().mass;
            gameObject.GetComponent<Rigidbody2D>().mass = massValue * massToResize;
            float newScale = scaleValue * reducingRate;
            transform.DOScale(newScale, timeToResize).SetEase(easetype).OnComplete(() =>
            {
                scaleValue = newScale;
            });
        }
    }

}
