using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int health = 5;

    public int level = 1;

    public float speep = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPositionz = transform.position;
      
        newPositionz.z += speed * Time.deltaTime;
       
        transform.position = newPositionz;
    }
}
