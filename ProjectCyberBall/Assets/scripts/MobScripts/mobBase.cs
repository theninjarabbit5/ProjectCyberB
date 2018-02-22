﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobBase : agentScript {

    /// <summary>
    ///Stores mobds attack/damage value
    ///Can be used to modify when buffed/spawned under alternate circumstances.
    ///Can vary between mobs.
    /// </summary>
    private bool attack;
    private bool Attack
    {

        get { return this.attack; }

        set { this.attack = value; }

    }

    /// <summary>
    /// Sets whether or not the minion is under the players thrall or the enemies
    /// False = Player controlled
    /// True = AI controlled
    /// Reason: Foe is shorter to type. Name can be changed
    /// </summary>
    private bool foe;
    private bool Foe
    {

        get { return this.foe; }

        set { this.foe = value; }

    }

    /// <summary>
    /// Tracks which hex the mob is currently standing on: [row, column]
    /// Stores position of hex in array.
    /// Can use physical hex position to position the mob
    /// </summary>
    private int[] standingHex;
    public int[] StandingHex {

        get { return this.standingHex; }

        set { this.standingHex = value; }

    }

    /// <summary>
    /// Stores a local copy of the map for mobs to be able to see and use
    /// Does this need to be a property?
    /// No
    /// Is it a property?
    /// Yes
    /// Why?
    /// Because it can be, ergo it is.
    /// </summary>
    private Map mapLocal;
    public Map MapLocal {

        get { return this.mapLocal; }

        set { this.mapLocal = value; }

    }

    private int moveDistance;
    public int MoveDistance {

        get { return this.moveDistance; }

        set { this.moveDistance = value; }

    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// Make an attack against an enemy Mob
    /// </summary>
    public virtual void mobAttack(mobBase target) {



    }

}
