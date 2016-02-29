using UnityEngine;
using System.Collections;

public class NumberWizzard : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		print("WELCOME TO NUMBER WIZARDS");
		print("PICK A NUMBER BUT NO TELL ME");
		
		int max = 1000;
		int min = 1;
		
		print("THE HIGHER NUMBER IS " + max);
		print("THE LOWEST NUMBER THAT YOU CAN PICK IS " + min);
		
		print("IS THE NUMBER LOWER THAN 500 or HIGER");
		print("UP ARROW FOR HIGHER, DOWN ARROW FOR LOWER and ,RETURN FOR EQUAL");
		
		
	}
	
	// Update is called once per frame
	void Update () {
	
	if (Input.GetKeyDown(KeyCode.UpArrow)) {
		print("Up ARROW PRESSED");
		}
	
	}
}
