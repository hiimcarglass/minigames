﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDoor : MonoBehaviour {

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "out")
        {
            this.name = "in";
        }
    }
}
