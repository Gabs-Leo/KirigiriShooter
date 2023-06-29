using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public int speed = 5;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    void FixedUpdate(){
        Vector3 direction = player.transform.position - transform.position;
        float distance = Vector3.Distance(transform.position, player.transform.position);

        if(distance > 2) {
            GetComponent<Rigidbody>().MovePosition(
                GetComponent<Rigidbody>().position +
                direction.normalized * speed * Time.deltaTime
            );

            Quaternion rotation = Quaternion.LookRotation(direction);
            GetComponent<Rigidbody>().MoveRotation(rotation);
        }
    }
}
