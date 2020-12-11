using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackController : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 heading;

    private void Start()
    {
        //Planeオブジェクト(親)取得
        GameObject PareObj = transform.parent.gameObject;
        //Quadオブジェクト(子)からPlaneオブジェクト(親)へのベクトル
        heading = PareObj.transform.position - transform.position;
        //Planeオブジェクト(親)のRigibodyコンポーネントを取得
        rb = PareObj.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(name);
        //Planeオブジェクト(親)に力を加える（方向：heading、大きさ：調整）
        rb.AddForce(heading, ForceMode.Force);
    }

}
