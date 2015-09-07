using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MenuController : MonoBehaviour {
	
	string score="";
	List<Scores> highscore;
	
	// Use this for initialization
	void Start () {
		
		highscore = new List<Scores>();
		
	}
	
	
	void ButtonClicked(GameObject _obj)
	{
		print("Clicked button:"+_obj.name);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI()
	{
		
				GUILayout.BeginHorizontal ();
				GUILayout.Label ("Score :");
				score = GUILayout.TextField (score);
				GUILayout.EndHorizontal ();

		
				if (GUILayout.Button ("Get LeaderBoard")) {
						highscore = HighScoreManager._instance.GetHighScore ();            
				}
		
				if (GUILayout.Button ("Clear Leaderboard")) {
						HighScoreManager._instance.ClearLeaderBoard ();            
				}
		
				GUILayout.Space (60);
		
				GUILayout.BeginHorizontal ();
				GUILayout.Label ("Scores", GUILayout.Width (Screen.width / 2));
				GUILayout.EndHorizontal ();
		
				GUILayout.Space (25);
		
				foreach (Scores _score in highscore) {
						GUILayout.BeginHorizontal ();
						GUILayout.Label ("" + _score.score, GUILayout.Width (Screen.width / 2));
						GUILayout.EndHorizontal ();
				}

				if (GUI.Button (new Rect (20, Screen.height - 50, 80, 20), "main menu")) {
						Application.LoadLevel ("menuscreen");
				}
		}

}
