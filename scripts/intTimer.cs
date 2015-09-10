using UnityEngine;
using System.Collections;

public class intTimer : MonoBehaviour {
	public GameObject GameMaster;

	// Use this for initialization
	void Start () {
	
	}
	//GmScript gmgone = GameMaster.GetComponent<GmScript>;
	//GmScript gmgone = GameMaster.gameObject.GetComponent<GmScript>();

	public float mytimer = 5f;

	// Update is called once per frame
	void Update () {
		if (mytimer > 0) {
				mytimer -= Time.deltaTime;
		}
		if (mytimer <= 0) {
			Destroy(this.gameObject);
			//gmgone.gone += 1;
		}
	}
}
