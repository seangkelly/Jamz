using UnityEngine;
using System.Collections;

public class AnimateDrums : MonoBehaviour {

	public bool playerHit;
	protected Animator MyAnimator;

	// Use this for initialization
	void Start () {

		playerHit = false;
	
	}

	protected void Awake(){
		MyAnimator = GetComponent<Animator> ();
		if(!MyAnimator) Debug.LogError("AnimatorComponent Not Found");
	}
	
	// Update is called once per frame
	protected void Update () {
		MyAnimator.SetBool ("playerHit", playerHit);
	}

	public void hitMe(){
		playerHit = true;
	}
}
