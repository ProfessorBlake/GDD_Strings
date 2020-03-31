using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parsing : MonoBehaviour
{
	public TextAsset BillOfRights;

	private string billString;

	private void Start()
	{
		billString = BillOfRights.text; //Set our string from the text in the text asset.
	}

	private void Update()
	{
		//Print the text to the console.
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			Debug.Log(billString);
		}

		//Split the text at each new line into an array, and prints a random string from the array.
		else if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			string[] splitText = billString.Split('\n');
			Debug.Log(splitText[Random.Range(0, splitText.Length)]);
		}

		//Create an array that holds each amendment and print a random one.
		else if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			int amend1Index = billString.IndexOf("Amendment I"); //The start of the amendments, as an int.
			string amendmentsString = billString.Substring(amend1Index); //A string that only contains the amendments.
			string[] amendments = amendmentsString.Split(new string[]{ "Amendment" }, System.StringSplitOptions.RemoveEmptyEntries); //Split the string at each occurance of "Amendment" to create an array of strings.

			//Print out each amendment
			foreach (string s in amendments)
				Debug.Log(s);
		}
	}
}
