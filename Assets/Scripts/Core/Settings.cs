﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour {

    public Transform navMeshAgent;

    private void Update() {
        HandleKeyInputs();
    }

    private void HandleKeyInputs() {
        if (Input.GetKeyDown(KeyCode.F12)) {

        } else if (Input.GetKeyDown(KeyCode.F11)) {

        }
    }
}