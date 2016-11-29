﻿using UnityEngine;
public class NavAgent : MonoBehaviour {

	private NavMeshAgent thisAgent;
	void Start () {
		thisAgent = GetComponent<NavMeshAgent>();
		StartGame.RunModGame += RunModGameHandler;
	}

    private void RunModGameHandler()
    {
        thisAgent.speed = StaticVars.moveSpeed;
    }

    public void ResetAgent (Transform destination) {
		thisAgent.destination = destination.position;
		thisAgent.speed = StaticVars.moveSpeed;
		thisAgent.Resume();
	}

	public void StopAgent () {
		thisAgent.Stop();
	}

}
