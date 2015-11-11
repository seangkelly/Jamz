﻿using UnityEngine;
using System.Collections;

public class PlayMusic : Photon.MonoBehaviour {
	public AudioClip clip;
	public AudioSource mySource;
	public float myVolume = 1.0f;
	string stringclip;

	public bool isLooping;
	private bool isPlaying = false;


	// Use this for initialization

	
	// Update is called once per frame
	/*void Update () {
		
		if(Input.GetKeyDown (KeyCode.Space))
			//GetComponent<ParticleSystem>().Emit(300);
			photonView.RPC("DoExploder",PhotonTargets.All, new object[]{1500});
		
		
		else if(Input.GetKeyDown (KeyCode.Return))
			//GetComponent<ParticleSystem>().Emit(1500);
			photonView.RPC("DoExploder",PhotonTargets.All, new object[]{1500});
		
	}
	*/

	public void PlaySound(AudioClip clip){

		stringclip = clip.ToString();
		Debug.Log (stringclip);

		photonView.RPC("PlaySoundHandler",PhotonTargets.All, null);

		//explosions
		photonView.RPC("DoExploder",PhotonTargets.All, new object[]{15});
	}


	[PunRPC]
	public void PlaySoundHandler ()//(string clipName)

	{
		if (isLooping) {

			mySource.clip = clip;
			mySource.loop = true;
			mySource.volume = 1.0f;
			mySource.Play();

		} else if (!isLooping) {
			mySource.PlayOneShot (clip, myVolume);
		}

		//this is just not working the way I want it to 
		if (isPlaying) {
			mySource.clip = clip;
			mySource.Pause ();
//			mySource.clip = clip;
//			mySource.loop = false;
//			mySource.Stop ();
			;

		} else {
			isPlaying = false;
			mySource.clip = clip;
			mySource.Play ();
		}
		
	}

	[PunRPC]
	public void DoExploder (int count)
	{
		GetComponent<ParticleSystem>().Emit(count);
		
	}

}
