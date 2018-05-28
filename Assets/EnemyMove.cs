using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
    public static bool IsDead = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector2(transform.position.x - 0.1f, transform.position.y);

        if (transform.position.x < -15)
        {
            transform.position = new Vector2(15f, transform.position.y);
        }
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet"))
        {
            Destroy(this.gameObject);
            IsDead = true;
        }
    }
}
