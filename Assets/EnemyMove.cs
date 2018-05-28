using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
    public bool IsDead = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector2(transform.position.x, transform.position.y - 0.1f);

        if (transform.position.y < -6)
        {
            transform.position = new Vector2(transform.position.x, 6f);
        }
	}
}
