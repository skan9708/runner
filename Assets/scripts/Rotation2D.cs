using UnityEngine;
using System.Collections;

public class Rotation2D : MonoBehaviour
{
    public int x=0;
    public int y=0;

	void Update () {
		transform.Rotate(new Vector2(x,y) * Time.deltaTime);
	}
}