using UnityEngine;
using System.Collections;

public class changeScene : MonoBehaviour
{
	int vidas = 3;
	public GameObject infoCerto;
	public GameObject infoErrado;


	public void goTo(string scene)
	{
		if (scene == "r")
			correto ();

		else if (scene == "w")
			errado ();

		else
			Application.LoadLevel (scene);
	}


	private void proxQuestao()
	{
			// something();
	}


	void correto()
	{
		float lTime = Time.time;
		infoCerto.SetActive (true);


	}


	void errado()
	{
		float lTime = Time.time;
		infoErrado.SetActive (true);


	}

}
