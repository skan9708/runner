using UnityEngine;
using System.Collections;

public class HurdleSpawner : MonoBehaviour {

    public GameObject Hurdle;
    public int duration = 100;
    public int sum = 0;

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
        GameObject hurdle = (GameObject)Instantiate(Hurdle);
        // 위치
        Vector2 spawnPosition = transform.position;
        hurdle.transform.position = spawnPosition;
        // 속도
        hurdle.GetComponent<Move2D>().x = -10f;
    }
}