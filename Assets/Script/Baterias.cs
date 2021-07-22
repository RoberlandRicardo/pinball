using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baterias : MonoBehaviour
{

    void OnCollisionEnter() {
        AreaStart.pontosInteiro += 20;
    }
}
