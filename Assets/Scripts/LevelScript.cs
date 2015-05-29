using UnityEngine;
using System.Collections;

public class LevelScript : MonoBehaviour {

	public void PromptMenu() {
		//TODO code a prompt here.
		//if user presses yes, this: otherwise nothing.
		Application.LoadLevel ("menu");
	}

	public void LoadLevel(string levelName) {
		Application.LoadLevel (levelName);
	}

	public void Update() {
		if(Input.GetKey (KeyCode.Escape)) {
			if(Application.levelCount == 0) {
				Application.Quit();
			}
			else {
				PromptMenu();
			}
		}
	}
}
