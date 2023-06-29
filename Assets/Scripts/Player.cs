using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Camera camera;
    public int speed = 10;
    Vector3 direction;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        move();
    }

    void FixedUpdate(){
        GetComponent<Rigidbody>().MovePosition(
            GetComponent<Rigidbody>().position + 
            (direction * speed * Time.deltaTime)
        );

        //Ray ray = GetComponent<Camera>().ScreenPointToRay(new Vector3());
    }

    void move() {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        direction = new Vector3(x, 0, z);
        if(direction != Vector3.zero)
            GetComponent<Animator>().SetBool("isRunning", true);
        else
            GetComponent<Animator>().SetBool("isRunning", false);
    }
}
