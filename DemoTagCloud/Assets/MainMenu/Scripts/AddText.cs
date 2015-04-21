using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AddText : MonoBehaviour {

	public GUIStyle boxStyle;
	public static Dictionary<string, int> words = new Dictionary<string, int>();

	public string stringToEdit = "Input Text Here";
	void OnGUI() {

		print (stringToEdit);
		int count;
		bool change;
		boxStyle = "box";
		boxStyle.wordWrap = true;
		boxStyle.fontSize = 20;
		boxStyle.alignment = TextAnchor.UpperLeft;
		stringToEdit = GUI.TextField (new Rect (100, 100, 600, 300), stringToEdit, boxStyle);		//displays button
		if (GUI.Button (new Rect (510,400, 100, 25), "Enter")) {
			//button clicked
			string [] split = stringToEdit.Split (new char [] {' ', ',', '.', ':', '\t' });

			foreach (string s in split) {
				if(!words.ContainsKey(s)){
					words.Add(s, 1);
				}
				else{
					count = words[s];
					count = count +1;
					words.Remove(s);
					words.Add(s, count);
				}
				
			}
			Application.LoadLevel("TheCloud");
		}

	}
	public static Dictionary<string, int> getWords(){
		return words;
	}

	void Update(){
		camera.backgroundColor = Color.white;
	}

	void Start(){
		stringToEdit = "Input Text Here";
	}
}