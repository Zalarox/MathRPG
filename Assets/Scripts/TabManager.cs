using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TabManager : MonoBehaviour {

	public GameObject panelsParent;

	void Start () {		
		SwitchMap ();
	}

	void DeactivateAll() {
		foreach (Transform child in panelsParent.transform) {
			child.gameObject.SetActive(false);
		}
	}

	void Activate(string name) {
		foreach (Transform child in panelsParent.transform) {
			if(child.name == name) {
				child.gameObject.SetActive(true);
			}
		}
	}

	public void SwitchMap() {
		DeactivateAll ();
		Activate ("MapPanel");	
	}

	public void SwitchQuests() {
		DeactivateAll ();
		Activate ("QuestsPanel");
	}

	public void SwitchSkills() {
		DeactivateAll ();
		Activate ("SkillsPanel");
	}

}
