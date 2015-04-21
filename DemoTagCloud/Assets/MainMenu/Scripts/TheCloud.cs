using UnityEngine;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

public class TheCloud : MonoBehaviour {

	public string word;
	public static Dictionary<string, int> words = new Dictionary<string, int>();
	GUIStyle largeFont;
	GUIStyle mediumFont;
	GUIStyle mediumSmallFont;
	Vector2 sizeOfLabel;
	private float offSetX;
	private float offSetY = 15;
	private int leftPosition = Screen.width / 2;
	private int topPosition = Screen.height / 2;
	private int boxHeight = 20;

	void Awake(){
		words = AddText.getWords();
		if (words.Count.Equals(0)) {
			words = MainMenu.getWords();
		}
	}
	// Use this for initialization
	void Start () {
		largeFont = new GUIStyle ();
		mediumFont = new GUIStyle ();
		mediumSmallFont = new GUIStyle ();

		largeFont.fontSize = 45;
		mediumFont.fontSize = 28;
		mediumSmallFont.fontSize = 20;

	}

	void Update(){
		Time.timeScale = 0.0f;
		camera.backgroundColor = Color.white;
	}

	void OnGUI () {
		displayWords ();
		if (GUI.Button (new Rect (550, 550, 100, 25), "Main Menu")) {
			Application.LoadLevel("MainScreen");
		}
	}


	public void displayWords(){
		int count = 0;

		foreach (KeyValuePair<string, int> kvp in words.OrderByDescending(i => i.Value)) {

			if (count == 0) {
				//Calculates the size of your label text with myStyle
				sizeOfLabel = largeFont.CalcSize (new GUIContent (kvp.Key));
				offSetX = sizeOfLabel.x + 6;
				GUI.Label (new Rect (leftPosition - offSetX / 2, topPosition + offSetY, offSetX, boxHeight), kvp.Key, largeFont);
			} else if (count == 1) {
				GUI.Label (new Rect (leftPosition + offSetX / 2 + 40, topPosition + offSetY, offSetX, boxHeight), kvp.Key, largeFont);
			} else if (count == 2) {
				GUI.Label (new Rect (leftPosition - offSetX / 2 -100, topPosition + offSetY, offSetX, boxHeight), kvp.Key, largeFont);
			} else if (count == 3){
				GUI.Label (new Rect (leftPosition - offSetX / 2, topPosition + offSetY + 40, offSetX, boxHeight), kvp.Key, largeFont);
			} else if (count == 4){
				GUI.Label (new Rect (leftPosition - offSetX / 2, topPosition + offSetY - 40, offSetX, boxHeight), kvp.Key, largeFont);
			} else if (count == 5){
				GUI.Label (new Rect (leftPosition - offSetX / 2, topPosition + offSetY - 80, offSetX, boxHeight), kvp.Key, mediumFont);
			} else if (count == 6) {
				GUI.Label (new Rect (leftPosition - offSetX / 2, topPosition + offSetY + 80, offSetX, boxHeight), kvp.Key, mediumFont);
			} else if (count == 7) {
				GUI.Label (new Rect (leftPosition - offSetX / 2 + 160, topPosition + offSetY + 40, offSetX, boxHeight), kvp.Key, mediumFont);
			} else if (count == 8){
				GUI.Label (new Rect (leftPosition - offSetX / 2 - 150, topPosition + offSetY + 40, offSetX, boxHeight), kvp.Key, mediumFont);
			} else if (count == 9){
				GUI.Label (new Rect (leftPosition - offSetX / 2 + 170, topPosition + offSetY - 40, offSetX, boxHeight), kvp.Key, mediumFont);
			} else if (count == 10){
				GUI.Label (new Rect (leftPosition - offSetX / 2 - 120, topPosition + offSetY - 40, offSetX, boxHeight), kvp.Key, mediumFont);
			} else if (count == 11) {
				GUI.Label (new Rect (leftPosition - offSetX / 2 + 180, topPosition + offSetY -84, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 12) {
				GUI.Label (new Rect (leftPosition - offSetX / 2 -180, topPosition + offSetY - 76, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 13){
				GUI.Label (new Rect (leftPosition - offSetX / 2 + 180, topPosition + offSetY + 82, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 14){
				GUI.Label (new Rect (leftPosition - offSetX / 2 - 180, topPosition + offSetY + 85, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 15){
				GUI.Label (new Rect (leftPosition - offSetX / 2, topPosition + offSetY + 100, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 16) {
				GUI.Label (new Rect (leftPosition - offSetX / 2, topPosition + offSetY - 100, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 17) {
				GUI.Label (new Rect (leftPosition - offSetX / 2 + 150, topPosition + offSetY + 100, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 18){
				GUI.Label (new Rect (leftPosition - offSetX / 2 - 120, topPosition + offSetY + 100, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 19){
				GUI.Label (new Rect (leftPosition - offSetX / 2 + 120, topPosition + offSetY - 100, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 20){
				GUI.Label (new Rect (leftPosition - offSetX / 2 - 100, topPosition + offSetY - 100, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 21) {
				GUI.Label (new Rect (leftPosition + offSetX / 2, topPosition + offSetY + 130, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 22) {
				GUI.Label (new Rect (leftPosition - offSetX / 2, topPosition + offSetY - 130, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 23){
				GUI.Label (new Rect (leftPosition - offSetX / 2 + 150, topPosition + offSetY + 130, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 24){
				GUI.Label (new Rect (leftPosition - offSetX / 2 - 155, topPosition + offSetY + 130, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 25){
				GUI.Label (new Rect (leftPosition - offSetX / 2 + 155, topPosition + offSetY - 130, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 26) {
				GUI.Label (new Rect (leftPosition - offSetX / 2 -150, topPosition + offSetY - 130, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 27) {
				GUI.Label (new Rect (leftPosition - offSetX / 2, topPosition + offSetY + 160, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 28){
				GUI.Label (new Rect (leftPosition - offSetX / 2, topPosition + offSetY - 160, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 29){
				GUI.Label (new Rect (leftPosition - offSetX / 2 + 150, topPosition + offSetY + 160, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 30){
				GUI.Label (new Rect (leftPosition - offSetX / 2 - 150, topPosition + offSetY + 160, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 31) {
				GUI.Label (new Rect (leftPosition - offSetX / 2 + 153, topPosition + offSetY -160, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 32) {
				GUI.Label (new Rect (leftPosition - offSetX / 2 -154, topPosition + offSetY - 160, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 33) {
				GUI.Label (new Rect (leftPosition + offSetX / 2 + 250, topPosition + offSetY + 130, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 34) {
				GUI.Label (new Rect (leftPosition - offSetX / 2 -250, topPosition + offSetY - 130, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 35){
				GUI.Label (new Rect (leftPosition - offSetX / 2 + 255, topPosition + offSetY + 160, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 36){
				GUI.Label (new Rect (leftPosition - offSetX / 2 - 250, topPosition + offSetY - 160, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 37){
				GUI.Label (new Rect (leftPosition - offSetX / 2, topPosition + offSetY + 190, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 38) {
				GUI.Label (new Rect (leftPosition - offSetX / 2, topPosition + offSetY - 190, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 39) {
				GUI.Label (new Rect (leftPosition - offSetX / 2 + 155, topPosition + offSetY + 190, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 40){
				GUI.Label (new Rect (leftPosition - offSetX / 2 - 155, topPosition + offSetY + 190, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 41){
				GUI.Label (new Rect (leftPosition - offSetX / 2 + 256, topPosition + offSetY + 190, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 42){
				GUI.Label (new Rect (leftPosition - offSetX / 2 - 256, topPosition + offSetY + 190, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 43) {
				GUI.Label (new Rect (leftPosition - offSetX / 2 + 153, topPosition + offSetY -190, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 44) {
				GUI.Label (new Rect (leftPosition - offSetX / 2 -154, topPosition + offSetY - 190, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 45) {
				GUI.Label (new Rect (leftPosition + offSetX / 2 + 240, topPosition + offSetY, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 46) {
				GUI.Label (new Rect (leftPosition - offSetX / 2 -250, topPosition + offSetY, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 47){
				GUI.Label (new Rect (leftPosition - offSetX / 2 + 256, topPosition + offSetY + 40, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 48){
				GUI.Label (new Rect (leftPosition - offSetX / 2 - 249, topPosition + offSetY - 40, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 49){
				GUI.Label (new Rect (leftPosition - offSetX / 2 + 251, topPosition + offSetY - 80, offSetX, boxHeight), kvp.Key, mediumSmallFont);
			} else if (count == 50) {
				GUI.Label (new Rect (leftPosition - offSetX / 2 + 240, topPosition + offSetY + 80, offSetX, boxHeight), kvp.Key, mediumSmallFont);
		}
		
		//GUI.Label (new Rect (x - 10, y, 80, 80), kvp.Key, largeFont);
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
