using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour {
    // Start is called before the first frame update
    public GameObject mob;
    public float mobsPerSecond = .2f;
    private float timer = 0;
    private float cooldown = 0;
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        timer += Time.deltaTime;
        if(timer >= 1) { 
            for(int i = 0; i < mobsPerSecond; i++) { 
                if(mobsPerSecond < 1) {
                    cooldown += mobsPerSecond;
                    if (cooldown >= 1) {
                        cooldown -= 1;
                        Instantiate(mob, transform.position, transform.rotation);
                    }
                } else {
                    Instantiate(mob, transform.position, transform.rotation);
                }
            }
            timer = 0;
        }
    }
}
