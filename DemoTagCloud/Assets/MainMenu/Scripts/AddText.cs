using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AddText : MonoBehaviour {

	public static Dictionary<string, int> words = new Dictionary<string, int>();

	public string stringToEdit = "Input Text Here";
	void OnGUI() {

		int count;
		bool change;
		GUIStyle boxStyle = "box";
		boxStyle.wordWrap = true;
		stringToEdit = GUI.TextField (new Rect (100, 100, 500, 200), stringToEdit, boxStyle);

		//displays button
		if (GUI.Button (new Rect (UnityEngine.Screen.width * 0.5f, UnityEngine.Screen.height * 0.5f, UnityEngine.Screen.width * .25f, UnityEngine.Screen.height * .1f), "Enter")) {
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
			foreach( KeyValuePair<string, int> kvp in words )
			{
				print("Key = " + kvp.Key + " Value = " + kvp.Value);
			}
			Application.LoadLevel("TheCloud");
		}

	}
	public static Dictionary<string, int> getWords(){
		return words;
	}
}