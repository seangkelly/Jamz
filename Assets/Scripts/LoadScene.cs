using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoadScene : MonoBehaviour {

	public Text updateText;
	public Text connectedPlayers;
	
	private bool loading = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (loading == true) {
			updateText.text = "Loading...";
		}

		// maintain a count of players that are connected
		connectedPlayers.text = PhotonNetwork.countOfPlayers + " connected players";

	}

	public void loadScene(){
		Application.LoadLevel (1);
		loading = true;

	}
}
