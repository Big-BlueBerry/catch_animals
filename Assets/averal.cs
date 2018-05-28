using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class averal : MonoBehaviour {
    public GameObject icon;
    public Transform AveralLocation;
    public float FireDelay;
    private bool FireState;

    public GameObject bullets;

	// Use this for initialization
	void Start () {
        FireState = true;	
	}
	
	// Update is called once per frame
	void Update () {
        playerFire();
	}

    private void playerFire()
    {
        if (FireState)
        {
            if (Input.GetKey(KeyCode.A))
            {
                StartCoroutine(FireCycleControl());
                var newBullet = Instantiate(icon, AveralLocation.position, AveralLocation.rotation);
                newBullet.transform.parent = bullets.transform;
            }
        }
    }

    IEnumerator FireCycleControl()
    {
        FireState = false;
        yield return new WaitForSeconds(FireDelay);
        FireState = true;
    }
}
