using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootStart : MonoBehaviour {

    public static ShootStart instance;

    public float interval;
    public GameObject bullet;
    public PhysicsObjectController physicsObject;
    bool shooting;

	// Use this for initialization
	void Start () {
        StartCoroutine(StartShooting());
	}

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update () {
		if(physicsObject.moving == true)
        {
            StopAllCoroutines();
            shooting = false;
        }
        else
        {
            if (shooting == false)
            {
                StartCoroutine(StartShooting());
            }
        }
	}

    public IEnumerator StartShooting()
    {
            shooting = true;
            GameObject bulletCreated = Instantiate(bullet, transform, false);
            bulletCreated.transform.SetParent(null);
            yield return new WaitForSeconds(interval);
            StartCoroutine(StartShooting());
    }
}
