using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public string inputName;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetAxis(inputName) > 0) {
            rb.AddForce(0, 0, 150, ForceMode.Impulse);
        } else {
            rb.AddForce(0, 0, -10, ForceMode.Impulse);
        }
    }
}
