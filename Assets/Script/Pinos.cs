using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinos : MonoBehaviour
{

    void OnCollisionEnter() {
        AreaStart.pontosInteiro += 10;
    }
}
