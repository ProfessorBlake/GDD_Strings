using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugging : MonoBehaviour
{
	private string preamble = "We the People of the United States, in Order to form a more perfect Union, establish Justice, insure domestic Tranquility, provide for the common defence, promote the general Welfare, and secure the Blessings of Liberty to ourselves and our Posterity, do ordain and establish this Constitution for the United States of America.";
	private string[] signed = new string[] { "Roger Sherman", "William Samuel Johnson" };

	private void Update()
	{
		//Print the preamble to the console.
		if(Input.GetKeyDown(KeyCode.Alpha1))
		{
			Debug.Log(preamble);
		}

		//Print the preamble and the names of Connecticut's Founding Fathers on new lines.
		else if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			Debug.Log("The US Constitution: " + preamble + "\n " + signed[0] + "\n " + signed[1]);
		}

		//Print the preamble and the names of Connecticut's Founding Fathers on new lines.
		else if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			Debug.Log($"The US Constitution: {preamble}\n {signed[0]}\n {signed[1]}");
		}

		//Print the preamble and the names of Connecticut's Founding Fathers on new lines.
		else if (Input.GetKeyDown(KeyCode.Alpha4))
		{
			Debug.Log(string.Format("The US Constitution: {0}\n {1}\n {2}", preamble, signed[0], signed[1]));
		}
	}
}
