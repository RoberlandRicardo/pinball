using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AtualizarPontos : MonoBehaviour
{

    // Update is called once per frame
    void Update() {

        GetComponent<TextMeshPro>().text = "Pontos: " + AreaStart.pontosInteiro;
    }
}
