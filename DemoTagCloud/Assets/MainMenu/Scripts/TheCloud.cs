using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public class TheCloud : MonoBehaviour {

	public string word;
	public static Dictionary<string, int> words = new Dictionary<string, int>();
	GUIStyle largeFont;
	int divide = 2;
	bool flag = true;

	void Awake(){
		words = AddText.getWords();
	}
	// Use this for initialization
	void Start () {
		largeFont = new GUIStyle ();
		largeFont.fontSize = 32;

	}

	void OnGUI () {
		displayWords ();
	}


	public void displayWords(){
		float yOffset = 0f;
		float xOffset = 0f;
		int count = 0;
		foreach( KeyValuePair<string, int> kvp in words.OrderByDescending(i => i.Value) )
		{
			GUI.Label (new Rect (xOffset + 350, yOffset + 250, 80, 80), kvp.Key, largeFont);

			yOffset = getY(count);
			xOffset = getX (count);
			count++;
		}
	}

	public float getY(int count){
		float y = 0;
		if (count == 0) {
			y = 35;
		} else if (count == 1) {
			y = 70;
		}else if (count == 2) {
			y = 100;
		}else if (count == 3) {
			y = -100;
		}else if (count == 4) {
			y = 120;
		}else if (count == 5) {
			y = -120;
		}else if (count == 6) {
			y = 72;
		}else if (count == 7) {
			y = 72;
		}else if (count == 8) {
			y = 72;
		}else if (count == 9) {
			y = 72;
		}else if (count == 10) {
			y = 72;
		}
		return y;
	}

	public float getX(int count){
		float x = 0;
		if (count == 0) {
			x = 35;
		} else if (count == 1) {
			x = 65;
		}else if (count == 2) {
			x = -81;
		}else if (count == 3) {
			x = -120;
		}else if (count == 4) {
			x = 140;
		}else if (count == 5) {
			x = 180;
		}else if (count == 6) {
			x = -200;
		}else if (count == 7) {
			x = 220;
		}else if (count == 8) {
			x = -230;
		}else if (count == 9) {
			x = 250;
		}else if (count == 10) {
			x = 300;
		}
		return x;
	}

}
