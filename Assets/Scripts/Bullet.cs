using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public int speed = 20;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void FixedUpdate() {
        GetComponent<Rigidbody>().MovePosition(
            GetComponent<Rigidbody>().position + 
            transform.forward * speed * Time.deltaTime
        );
    }
}
