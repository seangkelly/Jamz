using UnityEngine;
using System.Collections;

public class PlayParticles : Photon.MonoBehaviour {

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown (KeyCode.Space))
			//GetComponent<ParticleSystem>().Emit(300);
		photonView.RPC("DoExploder",PhotonTargets.All, new object[]{15});


		else if(Input.GetKeyDown (KeyCode.Return))
			//GetComponent<ParticleSystem>().Emit(1500);
		photonView.RPC("DoExploder",PhotonTargets.All, new object[]{1500});
			
	}

	[PunRPC]
	public void DoExploder (int count)
	{
		GetComponent<ParticleSystem>().Emit(count);

	}
}
