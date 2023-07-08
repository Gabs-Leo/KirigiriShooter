using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
    public int speed = 10;
    public LayerMask mask;
    public GameObject gameOverScreen;
    public bool isAlive = true;

    Vector3 direction;

    // Start is called before the first frame update
    void Start() {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update() {
        move();
        if (!isAlive)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                SceneManager.LoadScene("MainScene");
            }
        }
    }

    void FixedUpdate(){
        GetComponent<Rigidbody>().MovePosition(
            GetComponent<Rigidbody>().position + 
            (direction * speed * Time.deltaTime)
        );

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 500, Color.red);
        
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 500, mask)){
            Vector3 playerAim = hit.point - transform.position;
            playerAim.y = transform.position.y;

            Quaternion rotation = Quaternion.LookRotation(playerAim);
            GetComponent<Rigidbody>().MoveRotation(rotation);
        }

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
