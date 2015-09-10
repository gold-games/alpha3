using UnityEngine;
using System.Collections;

public class playercontrol : MonoBehaviour {

	public float maxSpeed = 10f;
	public float jumpForce = 20;
	bool facingRight = true;
	Animator anim;
	public Transform WaterPoint;
	public GameObject WaterBall;
	
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float move = Input.GetAxis ("Horizontal");
		anim.SetFloat ("movement", Mathf.Abs (move));
		if(Input.GetKeyDown(KeyCode.Z)){
			anim.SetBool("shoot", true);
			Instantiate(WaterBall, WaterPoint.position, WaterPoint.rotation);
		}
		if (Input.GetKeyUp (KeyCode.Z)) {
			anim.SetBool("shoot", false);
		}
		GetComponent<Rigidbody2D>().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

		if (move > 0 && !facingRight) {
			Flip ();
		} else if (move < 0 && facingRight) {
			Flip();
		}
	}

	void Update(){
		if(Input.GetKeyDown(KeyCode.Space)){
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
		}
	}

	void Flip(){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
