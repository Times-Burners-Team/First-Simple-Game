﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	// Game state
	int level;
	void Start () {
		ShowMainMenu();
	}
	
	
	void ShowMainMenu () {
		Terminal.ClearScreen();
		Terminal.WriteLine("What would you like to hack into?");
		Terminal.WriteLine("Press 1 for the local library");
		Terminal.WriteLine("Press 2 for the police station");
		Terminal.WriteLine("Enter your selection:");
	}
		
		
	void OnUserInput(string input) {
		if (input == "menu") {
			ShowMainMenu();
		} else if (input == "007") {
			Terminal.WriteLine("Please select a level Mr Bond");
		} else if (input == "1"){
			level = 1;
			StartGame(1);
		} else if (input == "2"){
			level = 2;
			StartGame(2); 
		} else {
			Terminal.WriteLine("Please choose a valid level");
		}
	}
	void StartGame(int level){
		Terminal.WriteLine("You have chosen level " + level);
		Terminal.WriteLine("Please enter your password: ");
	}
	
}
