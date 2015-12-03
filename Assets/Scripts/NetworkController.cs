﻿using UnityEngine;
using System.Collections;


public class NetworkController : MonoBehaviour
{
	string _room = "Tutorial_Convrge";

	//SPAWN SHITTTT
	/*
	private GameObject[] spawnPointList;
	private int SPLength;

	//AWAKE is for spawn setup
	void Awake(){

		//list of spawn points
		spawnPointList = GameObject.FindGameObjectsWithTag ("SpawnPoint");
		//size of array
		SPLength = spawnPointList.Length;

		Debug.Log ("this is kinda working");
		Debug.Log (SPLength);


	}
	*/
	void Start()
	{
		PhotonNetwork.ConnectUsingSettings("0.1");
		Debug.Log ("Connected");


	}
	
	void OnJoinedLobby()
	{
		Debug.Log("joined lobby");
		
		RoomOptions roomOptions = new RoomOptions() { };
		PhotonNetwork.JoinOrCreateRoom(_room, roomOptions, TypedLobby.Default);
	}
	

	void OnJoinedRoom()
	{

		//PhotonNetwork.Instantiate("CardboardMain", new Vector3(Random.Range(-5.0F, 5.0F), 0, Random.Range(-5.0F, 5.0F)), Quaternion.identity, 0);
		PhotonNetwork.Instantiate ("NetworkedPlayer", Vector3.zero, Quaternion.identity, 0);


	}

}