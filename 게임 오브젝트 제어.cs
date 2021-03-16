using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    //큐브의 강체
    public Rigidbody myRigidbody;
    //큐브에 가할 힘을 할당할 변수
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        //큐브에 힘을 가함
        myRigidbody.AddForce(0,force,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
