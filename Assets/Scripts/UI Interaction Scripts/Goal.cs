﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> Representation of a Player Goal. </summary>
public class Goal {
    public int myId; //Owning player ID
    public int id; // Target Player ID
    public enum goalOptions { die, live } // What goals you can be given
    public goalOptions goal; // Players' goal

    /// <summary> Representation of a Player Goal. </summary>
    /// <param name="id"> Target Player ID. </param>
    /// <param name="goal"> Current Player Goal. </param>
    public Goal (int myId, int id, goalOptions goal) {
        this.myId = myId;
        this.id = id;
        this.goal = goal;
    }

    public override string ToString()
    {
        return ($"Goal: Player: {myId}, Target: {id}, goal: {goal.ToString()}");
    }
}
