using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public bool grounded=false;
    public float jumpspeed=15;

    void OnCollisionEnter2D (Collision2D collidingObject)
	{
        if (collidingObject.gameObject.tag == "Ground")
        {
		    grounded = true;
        }
        else if (collidingObject.gameObject.tag == "Coin")
        {
            Destroy(collidingObject.gameObject);
            GameObject.Find("Score").GetComponent<Score>().AddScore(1);
        }
	}

	void OnCollisionExit2D (Collision2D collidingObject)
	{
        if (collidingObject.gameObject.tag == "Ground")
    	{
            grounded=false;
        }
	}

    void FixedUpdate()
    {
        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpspeed, ForceMode2D.Impulse);
        }
    }
}
