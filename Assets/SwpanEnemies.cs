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
        if (EnemyMove.IsDead == true)
        {
            SpawnRandomEnemy();
            EnemyMove.IsDead = false;
        }
    }

    void SpawnRandomEnemy()
    {
        num = Random.Range(0, 5);
        GameObject newenemy = Instantiate(PlayerMove.MoveInstance.Enemies[num], new Vector2(15f,Random.Range(-4, 4)), Quaternion.identity);
        newenemy.transform.parent = Enemys.transform;
    }
}
