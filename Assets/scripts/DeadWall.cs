using UnityEngine;
using System.Collections;

public class DeadWall : MonoBehaviour {

    void OnTriggerEnter2D (Collider2D other)
	{
        // 단순히 충돌한 대상을 없앤다.
		Destroy(other.gameObject);
	}
}
