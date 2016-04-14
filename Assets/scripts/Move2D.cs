using UnityEngine;
using System.Collections;

public class Move2D : MonoBehaviour {

	public float x = 0;
    public float y = 0;

	void Update ()
    {
        transform.Translate(new Vector2(x, y) * Time.deltaTime, Space.World);
	}
}
