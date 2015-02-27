using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using words;

public class AddText : MonoBehaviour {

	
	public Dictionary<string,int> myDict;
	public string stringToEdit = "Input Text Here";
	void OnGUI() {

		
		stringToEdit = GUI.TextField(new Rect(100, 100, 500, 200), stringToEdit, 25);

		//displays button
		if (GUI.Button (new Rect(UnityEngine.Screen.width * 0.5f, UnityEngine.Screen.height * 0.5f, UnityEngine.Screen.width * .25f, UnityEngine.Screen.height * .1f), "Enter")){
			//button clicked
			string [] split = stringToEdit.Split(new char [] {' ', ',', '.', ':', '\t' });
			
			foreach (string s in split) {

				if (s.Trim() != "")
					print(s);
			}
			
		}
	}
}
