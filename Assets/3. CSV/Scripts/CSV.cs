using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSV : MonoBehaviour
{
	public TextAsset Grades;

	private string gradesString;

	private void Start()
	{
		gradesString = Grades.text;
		Debug.Log("Grades:\n" + gradesString);
	}

	private void Update()
	{
		//Show highest grades.
		if(Input.GetKeyDown(KeyCode.Alpha1))
		{
			ShowHighScores();
		}

		//Show highest grades.
		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			ShowAverage();
		}
	}

	private void ShowHighScores()
	{
		string[] entries = gradesString.Split('\n'); //Split string on New Lines into array of strings: "Name,Grade"

		int highestGrade = 0; //Variable to hold highest score.
		List<string> studentsWithHighestScore = new List<string>(); //List of all strings with the highest score.
		foreach (string s in entries) // "Name,Grade"
		{
			if (string.IsNullOrEmpty(s)) //Skip empty strings
				continue;

			int score = int.Parse(s.Split(',')[1]); //int.Parse will convert a string into an int, if it can. 
			if (score == highestGrade) //If this students score is the same as the highest score, add their entry to list.
			{
				studentsWithHighestScore.Add(s);
			}
			else if (score > highestGrade) // set a new highest score.
			{
				highestGrade = score;
				studentsWithHighestScore = new List<string>() { s }; //Reset the list and add this entry to it.
			}
		}

		Debug.Log("Highest Scores:");
		foreach (string s in studentsWithHighestScore) //For all entries in highscore list
		{
			string name = s.Split(',')[0];
			string score = s.Split(',')[1];
			Debug.Log(name + ": " + score);
		}
	}

	private void ShowAverage()
	{
		string[] entries = gradesString.Split('\n'); //Split string on New Lines into array of strings: "Name,Grade"

		int totalEntries = 0;
		float totalPoints = 0f;
		
		foreach (string s in entries) // "Name,Grade"
		{
			if (string.IsNullOrEmpty(s))
				continue;

			totalEntries++;
			totalPoints += float.Parse(s.Split(',')[1]);
		}

		Debug.Log("Class average: " + (totalPoints / totalEntries).ToString());
	}
}
