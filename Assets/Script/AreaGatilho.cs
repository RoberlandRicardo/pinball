using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaGatilho : MonoBehaviour
{
    private bool areaDeAcao = false;

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.name == "Bola") {
            areaDeAcao = true;
        }
    }

    void OnTriggerExit(Collider col) {
        if (col.gameObject.name == "Bola") {
            areaDeAcao = false;
        }
    }

    public bool getAreaDeAcao() {
        return areaDeAcao;
    }
}
