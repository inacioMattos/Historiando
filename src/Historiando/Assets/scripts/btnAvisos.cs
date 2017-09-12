using UnityEngine;
using System.Collections;

public class btnAvisos : MonoBehaviour {

	private float lTime;
	private float cTime;
	private bool check = false;

	// Use this for initialization
	void Start ()
	{
		lTime = Time.time;
		cTime = Time.time;
	}

	// Update is called once per frame
	void Update ()
	{
		cTime = Time.time;

		if (this.gameObject.activeSelf && !check)
			lTime = Time.time;
		else if (this.gameObject.activeSelf && cTime - lTime > 3)
			this.gameObject.SetActive(false);
	}
}
