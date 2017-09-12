using UnityEngine;
using System.Collections;

public class anchors : MonoBehaviour
{
	public float anchorRoma;
	public float anchorGrecia;
	public GameObject bg;


	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{

	}

	public void click(string x)
	{
		if (x == "roma")
		{
			bg.transform.localPosition = new Vector3 (0f, 2080f, 0f);
		}
		else
		{
			bg.transform.localPosition = new Vector3 (0f, 4.97f, 0f);
		}
	}
}
