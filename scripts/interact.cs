using UnityEngine;
using System.Collections;

public class interact : MonoBehaviour {

	public GameObject player1;
	public float Distance;
	public float Range = 15.0f;
	public Transform target;
	public bool talk = false;
	float mytimer = 1000f;
	Animator anim;
	void Start () {
		anim = player1.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		Distance = Vector3.Distance (transform.position, target.position);
		if (Distance < Range) {talk = true;}
		if (mytimer > 0) {
			mytimer -= Time.deltaTime + 1;
		}
	}

	void OnTriggerStay2D (Collider2D other)
	{
		if (other.gameObject.CompareTag("Player") == true);
		{
			if (Input.GetKeyDown(KeyCode.E)) {
				anim.SetBool("interact", true);
			}
			if (Input.GetKeyUp(KeyCode.E)){
				anim.SetBool("interact", false);
				Destroy(this);
			}
		}
}
	void OnGUI(){
		if (talk) {
			Vector3 getPixelPos = Camera.main.WorldToScreenPoint( target.position );
			getPixelPos.y = Screen.height - getPixelPos.y;
			GUI.Label( new Rect(getPixelPos.x,getPixelPos.y,200f,100f) , "1000/"+mytimer+"");
		}
}
}