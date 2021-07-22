using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaStart : MonoBehaviour {

    private static System.Timers.Timer timer;
    public static int pontosInteiro = 0;

    // void Update() {
    //     jogoStart = 
    // }
    // void Start() {
        // pontos = GameObject.Find("Pontos").GetComponent<TextMeshPro>();
    // }
    void Update() {
        if (VerificarStart.jogoStart == false) {
            if (timer != null) {
                timer.Enabled = false;
            }
        }
    }

    void OnTriggerEnter(Collider col) {
        
        if (col.gameObject.name == "Bola" && VerificarStart.jogoStart == false) {
            VerificarStart.jogoStart = true;
            pontosInteiro = 0;
            timer = new System.Timers.Timer();
            timer.AutoReset = false;
            timer.Interval = 1000;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(adicionarPontos);
            timer.Enabled = true;
        }
    }

    static void adicionarPontos(object sender, System.Timers.ElapsedEventArgs e) {
        timer.Enabled = false;
        pontosInteiro++;

        timer.Enabled = true;
    }
    
}
