using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaretController : MonoBehaviour   
{
    

    [SerializeField]
    private float x_min = -5.0f;

    [SerializeField]
    private float x_max = 5.0f;

    [SerializeField]
    private float y_tablehight = 0.3f;

    [SerializeField]
    private float z_min = -10.0f;

    [SerializeField]
    private float z_max = 10.0f;


    //void Start()
    //{
    //}

    //private void OnMouseDown()
    //{
    //}

    //private void OnMouseDrag()
    //{
    //}

    void Update()
    {
        //スクリーン上の座標
        Vector2 touchScreenPosition = Input.mousePosition;

        touchScreenPosition.x = Mathf.Clamp(touchScreenPosition.x, 0.0f, Screen.width);
        touchScreenPosition.y = Mathf.Clamp(touchScreenPosition.y, 0.0f, Screen.height);

        //3D座標に変換
        Camera gameCamera = Camera.main;
        Ray touchPointToRay = gameCamera.ScreenPointToRay(touchScreenPosition);


        RaycastHit hitInfo = new RaycastHit();
        if (Physics.Raycast(touchPointToRay, out hitInfo))//Colliderが付いているオブジェクト上限定
        {
            //m_object.transform.position = hitInfo.point;

            transform.position = new Vector3(Mathf.Clamp(hitInfo.point.x, x_min, x_max),y_tablehight, Mathf.Clamp(hitInfo.point.z, z_min, z_max));


        }
    }
}
