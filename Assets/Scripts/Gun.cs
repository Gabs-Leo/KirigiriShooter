using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour{

    public GameObject bullet;
    public GameObject gunFire;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Fire1")){
            Instantiate(bullet, gunFire.transform.position, gunFire.transform.rotation);
        }
    }

}
