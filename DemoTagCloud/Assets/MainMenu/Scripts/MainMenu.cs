using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Texture backgroundTexture;
	public GUIStyle buttonTexture;

	public float buttonX1 = .4f;
	public float buttonY1 = .6f;
	public float buttonX2 = .4f;
	public float buttonY2 = .72f;

	void OnGUI(){
		//display background text
		GUI.DrawTexture (new Rect (0, 0, UnityEngine.Screen.width, UnityEngine.Screen.height), backgroundTexture);

		//displays our buttons
		if (GUI.Button (new Rect(UnityEngine.Screen.width * buttonX1, UnityEngine.Screen.height * buttonY1, UnityEngine.Screen.width * .25f, UnityEngine.Screen.height * .1f), "Upload File")){
			//button clicked
			UnityEditorInternal.InternalEditorUtility.OpenFileAtLineExternal(@"C:\1.txt", 1);

		}

		if (GUI.Button (new Rect(UnityEngine.Screen.width * buttonX2, UnityEngine.Screen.height * buttonY2, UnityEngine.Screen.width * .25f, UnityEngine.Screen.height * .1f), "Add Text")){
			//button clicked
			Application.LoadLevel("AddText");
		}

	}

	void openPanel(){

	}




}
