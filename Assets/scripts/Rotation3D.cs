using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour
{
	void Update () {
		transform.Rotate(new Vector3(3,2,1) * 50 * Time.deltaTime);
	}
}
