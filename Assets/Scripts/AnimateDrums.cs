using UnityEngine;
using System.Collections;

public class AnimateDrums : Photon.MonoBehaviour {

	protected Animator MyAnimator;

	// Use this for initialization
	void Start () {
			
	}

	protected void Awake(){
		MyAnimator = GetComponent<Animator> ();
		if(!MyAnimator) Debug.LogError("Animator Component Not Found");
	}
	
	// Update is called once per frame
	protected void Update () {

	}

	public void hitMe(){

		photonView.RPC ("hitAll", PhotonTargets.All, null);

	}

	[PunRPC]
	public void hitAll(){

		MyAnimator.SetTrigger ("playerHitMe");
		Debug.Log ("playerHitMe triggered");

	}
	
}