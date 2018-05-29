using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour {
    public static PlayerMove MoveInstance;
    public GameObject[] Enemies;
    private int Wtime = 2;
    private float time;

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

        time += Time.deltaTime;

        if (time >= Wtime)
        {
            foreach (GameObject enemy in Enemies)
                SpawnEnemy(enemy);
            time = 0;
        }

    }

    void SpawnEnemy(GameObject enemy)
    {
        var num = Random.Range(0, 4);
        GameObject newenemy = Instantiate<GameObject>(enemy, new Vector2(15f, Random.Range(-4, 4)), Quaternion.identity);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("GameOver");
            Destroy(this.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
