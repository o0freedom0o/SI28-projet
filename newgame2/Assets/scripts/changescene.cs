using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
		

public class changescene : MonoBehaviour {

	public void next()
	{
		Application.LoadLevel (1);
	}
	public void next1()
	{
		Application.LoadLevel (2);
	}
	public void next2()
	{
		Application.LoadLevel (0);
	}
	public void next3()
	{
		Application.LoadLevel (3);
	}
}
