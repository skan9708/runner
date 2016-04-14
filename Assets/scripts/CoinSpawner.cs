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
        coin.GetComponent<Move2D>().x = -10f;
        // 회전
        coin.GetComponent<Rotation2D>().y = 150;
    }
}
