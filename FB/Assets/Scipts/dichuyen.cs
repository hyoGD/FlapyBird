using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dichuyen : MonoBehaviour
{
    public float MoveSpeed;
    public float MoveRange;             //pham vi

    private GameObject obj;
    private Vector3 OldPosition;        //vi tri cu
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        OldPosition = obj.transform.position;
        MoveSpeed = 5f;
        MoveRange = 54f;
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(new Vector3(-1 * Time.deltaTime * MoveSpeed, 0, 0));    //di chuyen background

        if (Vector3.Distance(OldPosition, obj.transform.position) > MoveRange)           //nếu vị trí hiện tại lớn hơn phạm vị thì sẽ trở về vị trí cũ
        {
            obj.transform.position = OldPosition;
        }
    }
}
