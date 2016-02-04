using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	// Global variables and constants
	int max, min, mid;
	string guess, instruct;
	char upArrow, downArrow;
	
	// Use this for initialization
	void Start () {
			StartGame();		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			print("up arrow was pressed");
			// Set the new minimum to one higher than the old middle value
			min = mid +1;
			
			// Set the new middle value
			GetMiddle();
			
			// make new guess
			Guess();			
			
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			print("down arrow was pressed");
			
			// Set ne maximum to one lower than the old middle value
			max = mid -1;
			
			// Set the new middle value
			GetMiddle();
			
			// make new guess
			Guess();	
			
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print("I won!");
			StartGame();
		}
	}
	
	void StartGame() {
		max = 1000;
		min = 1;
		mid = 500;
		upArrow = '\u2191';
		downArrow = '\u2193';
		
		instruct = "press up " + upArrow + " for higher, press down " + downArrow + " for lower, enter for equal";
		
		print("============================================");
		print("Welcome to NUmber Wizard");
		print("Pick a number in your head but don't tell me");			
		
		print("Pick a number between " + min + " and " + max);	
		
		Guess();
	}
	
	void GetMiddle() {
		int spread;
		spread = max - min;
		mid = max - spread/2;	
	}
	
	void Guess() {
		guess = "is the number higher or lower than " + mid + "?";
		print(guess);
		print(instruct);
	}
}
