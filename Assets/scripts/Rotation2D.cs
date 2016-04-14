using UnityEngine;
using System.Collections;

public class Rotation2D : MonoBehaviour
{
    public int x=3;
    public int y=3;

    public int scale=50;

	void Update () {
		transform.Rotate(new Vector2(x,y) * scale * Time.deltaTime);
	}
}