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
	}

    void OnTriggerEnter2D (Collider2D collidingObject)
    {
        if (collidingObject.gameObject.tag == "Coin")
        {
            Destroy(collidingObject.gameObject);
            GameObject.Find("Score").GetComponent<Score>().Add(1);
        }

        if (collidingObject.gameObject.tag == "Hurdle")
        {
            Heart heart = GameObject.Find("Heart").GetComponent<Heart>();
            heart.Add(-1);

            if (heart.count <= 0)
            {
                GetComponent<SceneChanger>().ToScene("main");
            }
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
        if (grounded && (Input.GetKeyDown(KeyCode.Space) || Input.GetKey(KeyCode.Space)))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpspeed, ForceMode2D.Impulse);
        }
    }
}
