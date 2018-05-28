using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwpanEnemies : MonoBehaviour {
    public GameObject Enemys;
    public int num;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + 0.1f);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            SpawnRandomEnemy();

            collision.GetComponent<EnemyMove>().IsDead = true;

            if (collision.GetComponent<EnemyMove>().IsDead == true)
            {
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
            }
        }
    }

    void SpawnRandomEnemy()
    {
        num = Random.Range(0, 5);
        GameObject newenemy = Instantiate(PlayerMove.MoveInstance.Enemies[num], new Vector2(Random.Range(-12, 12), 5.15f), Quaternion.identity);
        newenemy.transform.parent = Enemys.transform;
    }
}
