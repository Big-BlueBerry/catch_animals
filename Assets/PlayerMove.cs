using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    public static PlayerMove MoveInstance;
    public GameObject[] Enemies;
    // Use this for initialization
    void Start()
    {
        MoveInstance = this;
        foreach (GameObject enemy in Enemies)
            SpawnEnemy(enemy);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector2(transform.position.x - 0.5f, transform.position.y);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector2(transform.position.x + 0.5f, transform.position.y);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.5f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 0.5f);
        }
    }

    void SpawnEnemy(GameObject enemy)
    {
        var num = Random.Range(0, 4);
        GameObject newenemy = Instantiate<GameObject>(enemy, new Vector2(Random.Range(-12, 12), 5.15f), Quaternion.identity);
    }
}
