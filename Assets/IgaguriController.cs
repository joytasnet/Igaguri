using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriController : MonoBehaviour
{
    //Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate=60;
        //rb = GetComponent<Rigidbody>();
        //Shoot(new Vector3(0,200,2000));
        
    }
    public void Shoot(Vector3 dir){
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision collision) {
        GetComponent<Rigidbody>().isKinematic=true;
        GetComponent<ParticleSystem>().Play();
        //Destroy(collision.gameObject);
    }
}
