using UnityEngine;
using System.Collections;

public class Rotation3D : MonoBehaviour
{
    public int x=3;
    public int y=3;
    public int z=1;
    public int scale=50;

	void Update () {
		transform.Rotate(new Vector3(x,y,z) * scale * Time.deltaTime);
	}
}
