using UnityEngine;
using System.Collections;

public class CSharpTut : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Variables myClass;
		myClass = new Variables ();
		
		myClass.Test ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}






}
public class Variables
{
	public void Test()
	{
		int x= 100;
		int y;
		y = 150;

		int z;
		z = x + y;


		/* precondition while*/
		/* execute zero or more times */
		/*positive loop*/
		bool islooping = true;
		int counter = 0;

			{
			Debug.Log (++counter);
			islooping = counter <= 100;
			while ( /* condition*/ islooping );
		}
	}
}