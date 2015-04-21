using UnityEngine;
using System;
using System.Collections.Generic;
using System.IO;

public class MainMenu : MonoBehaviour {

	public Texture backgroundTexture;
	public GUIStyle buttonTexture;

	public float buttonX1 = .4f;
	public float buttonY1 = .6f;
	public float buttonX2 = .4f;
	public float buttonY2 = .72f;

	public String input;
	public int count;
	public static Dictionary<string, int> words = new Dictionary<string, int>();

	void OnGUI(){
		buttonTexture.fontSize = 20;
		//display background text
		GUI.DrawTexture (new Rect (0, 0, UnityEngine.Screen.width, UnityEngine.Screen.height), backgroundTexture);

		//displays our buttons
		if (GUI.Button (new Rect(UnityEngine.Screen.width * buttonX1, UnityEngine.Screen.height * buttonY1, UnityEngine.Screen.width * .15f, UnityEngine.Screen.height * .05f), "Upload File", buttonTexture)){
			readFile("ReadMe.txt");
			Application.LoadLevel("TheCloud");
		}

		if (GUI.Button (new Rect(UnityEngine.Screen.width * buttonX2, UnityEngine.Screen.height * buttonY2, UnityEngine.Screen.width * .15f, UnityEngine.Screen.height * .05f), "Add Text", buttonTexture)){
			//button clicked
			Application.LoadLevel("AddText");
		}

	}

	void readFile(String file){
		if (File.Exists (file)) {
			var sr = File.OpenText (file);
			var line = sr.ReadLine ();
			while (line != null) {
				print (line);
				string [] split = line.Split (new char [] {' ', ',', '.', ':', '\t' });
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
				line = sr.ReadLine ();
			}
			sr.Close();
		} else {
			print ("could not open file " + file + " for reading");
			return;
		}
	}

	public static Dictionary<string, int> getWords(){
		return words;
	}

}
