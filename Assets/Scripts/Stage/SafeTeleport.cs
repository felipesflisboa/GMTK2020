﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeTeleport : MonoBehaviour {
    void OnTriggerEnter(Collider other) {
        var orb = other.GetComponentInParent<Orb>();
        if (orb != null)
            orb.TeleportBackToLastSegment();
    }
}
