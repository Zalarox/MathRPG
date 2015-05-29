using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TabManager : MonoBehaviour {

	public GameObject panelParent;
	CanvasGroup[] cgArray;

	void Start () {		
		cgArray = panelParent.GetComponentsInChildren<CanvasGroup> ();
		SwitchMap ();
	}

	void DeactivateAll() {
		foreach (CanvasGroup cg in cgArray) {
			cg.alpha = 0;
		}
	}

	void Activate(string name) {
		foreach (CanvasGroup cg in cgArray) {
			if(cg.gameObject.name == name) {
				cg.alpha = 1;
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
