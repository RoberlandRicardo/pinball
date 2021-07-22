using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gatilho : MonoBehaviour
{
    public GameObject bola;
    public float constanteScale = 4000;
    private float forca = 0;
    private Vector3 scaleInicial;
    private bool areaDeAcao;
    // Start is called before the first frame update
    void Start()
    {
        scaleInicial = transform.localScale;
    }

    // Update is called once per frame
    void Update(){
        Vector3 scalaAtual = transform.localScale;
        areaDeAcao = GameObject.Find("VerificarGatilho").GetComponent<AreaGatilho>().getAreaDeAcao();
        if (Input.GetAxis("Gatilho") > 0) {
            if (scalaAtual.y > 0.35) {
                forca++;
                transform.localScale = new Vector3(scalaAtual.x, scalaAtual.y - (forca / constanteScale), scalaAtual.z);
            }
        } else if (Input.GetAxis("Gatilho") == 0) {
            Rigidbody rbBola = bola.GetComponent<Rigidbody>();
            if (areaDeAcao) {
                rbBola.AddForce(0, 0, forca * 10, ForceMode.Impulse);
            }
            transform.localScale = scaleInicial;
            forca = 0;
        }
    }
}
