using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEnd : MonoBehaviour
{
    void OnTriggerEnter(Collider col) {
        VerificarStart.jogoStart = false;
    }
}
