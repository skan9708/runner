using UnityEngine;
using System.Collections;

public class CoinSpawner : MonoBehaviour
{
    public GameObject Coin;
    public int duration=100;
    public int sum=0;

    void Update()
    {
        if (sum == duration)
        {
            sum = 0;
            Spawn();
            return;
        }
        sum += 1;
    }

    void Spawn()
    {
        GameObject coin = (GameObject)Instantiate(Coin);
        // 위치
        Vector2 spawnPosition = transform.position;
        coin.transform.position = spawnPosition;
        // 속도
        Rigidbody2D rb = coin.GetComponent<Rigidbody2D>();
        Vector2 v = rb.velocity;
        v.x -= 10;
        rb.velocity = v;
    }
}
