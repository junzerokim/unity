using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate() // rigid 관련 코드는 FixedUpdate에 작성
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);
        //
        rigid.AddForce(vec, ForceMode.Impulse);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Cube")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
            
    }

    // 실제 물리적인 충돌로 발생하는 이벤트
    void OnCollisionEnter(Collision other) { }
    void OnCollisionStay(Collision other) { }
    void OnCollisionExit(Collision other) { }

    // 콜라이더 충돌로 발생하는 이벤트
    void OnTriggerEnter(Collider other) { }
    void OnTriggerStay(Collider other) { }
    void OnTriggerExit(Collider other) { }
}
