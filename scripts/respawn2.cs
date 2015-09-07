using UnityEngine;
using System.Collections;

public class respawn2 : MonoBehaviour {
	Health2 myHealth2;
	float deathtimeout = 0;
	float animationtime;

	/*// Use this for initialization
	void Start () {
		myHealth2 = GetComponent<Health2>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (myHealth2.currentHealth2 <= 0) {
			transform.position = GameObject.FindGameObjectWithTag ("Respawn 2").transform.position;
			myHealth2.currentHealth2 = 100;
		}
	}
}*/
	private enum PlayerState
	{
		ALIVE,
		DYING,
		DEAD
	}
	
	private Animator anim;
	private PlayerState state;
	
	// Use this for initialization
	void Start ()
	{
		anim = this.transform.GetComponent<Animator>();
		myHealth2 = GetComponent<Health2>();
		state = PlayerState.ALIVE;
		//potentially force a forever clamp on your animation if setting it in inspector is not working for you
		//animation["MOB1_M1_Stand_Relaxed_Death_B"].wrapMode = WrapMode.ClampForever;
	}
	
	// Update is called once per frame
	void Update ()
	{
		deathtimeout -= Time.deltaTime;
		animationtime -= Time.deltaTime;
		switch (state) {
		case PlayerState.ALIVE:

			//Things that you would call every frame while the character is alive
			if (myHealth2.currentHealth2 <= 0) {
				state = PlayerState.DYING;
			}
			break;
		case PlayerState.DYING:
			//things you need to do to "kill" the character
			StartCoroutine (TriggerAnimator ("death"));
			animationtime = 4f;

		//animation.Play("MOB1_M1_Stand_Relaxed_Death_B");
			//THIS IS THE THING THAT HELPS YOU
			//THE PLAYER IS NOW ONLY DYING FOR ONE FRAME AND The ANIMATION PLAY IS ONLY CALLED ONCE
			state = PlayerState.DEAD;
			break;
		case PlayerState.DEAD:
			
			//Anything you need to do to clean up the character such as removing them from the scene or respawning, etc.
			if(deathtimeout <= 0 && animationtime <= 0){
				transform.position = GameObject.FindGameObjectWithTag ("Respawn 2").transform.position;
				myHealth2.currentHealth2 = 100;
				deathtimeout = 4.0f;
				state = PlayerState.ALIVE;
			}
			break;
		}
	}
	private IEnumerator TriggerAnimator (string name){
		anim.SetTrigger(name);
		yield return null;
		//anim.SetTrigger(name, false);
	}
	
}
	
