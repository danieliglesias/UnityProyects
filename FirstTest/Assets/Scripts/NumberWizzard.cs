using UnityEngine;
using System.Collections;

public class NumberWizzard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;

	void Start () {
		
		StartGame();
		
		
	}
	void StartGame(){
		max = 1000;
		min = 1;
		guess = 500;
		
	
		print("======================================");
		print("WELCOME TO NUMBER WIZARDS");
		print("PICK A NUMBER BUT NO TELL ME");
		
		print("THE HIGHER NUMBER IS " + max);
		print("THE LOWEST NUMBER THAT YOU CAN PICK IS " + min);
		
		print("IS THE NUMBER LOWER THAN "+ guess +" or HIGER");
		print("UP ARROW FOR HIGHER, DOWN ARROW FOR LOWER and ,RETURN FOR EQUAL");
		
		max = max + 1;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess;
			NextGuess();
		}else if (Input.GetKeyDown(KeyCode.DownArrow)) {	
			max = guess;
			NextGuess();	
		}else if (Input.GetKeyDown(KeyCode.Return)) {
			print("I WON");
			StartGame();
		}
	
	
	}
	void NextGuess(){
		guess = (max + min)/2;
		print("Higher or lower than "+ guess);
		print("UP ARROW FOR HIGHER, DOWN ARROW FOR LOWER and ,RETURN FOR EQUAL");
	}
}
