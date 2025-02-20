using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float minX = -3f;  // ī�޶� �̵��� �� �ִ� X�� �ּҰ�
    public float maxX = 3f;   // ī�޶� �̵��� �� �ִ� X�� �ִ밪
    public float minY = -5f;  // ī�޶� �̵��� �� �ִ� Y�� �ּҰ�
    public float maxY = 11f;   // ī�޶� �̵��� �� �ִ� Y�� �ִ밪
    public float smoothSpeed = 0.2f; // ī�޶� �̵� �ӵ�

    void FixedUpdate()
    {
        if (target == null)
            return;

        Vector3 pos = transform.position;
        pos.x = target.position.x;
        pos.y = target.position.y;

        // ī�޶� ��ġ�� ���� ���� ���� ����
        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        transform.position = Vector3.Lerp(transform.position, pos, smoothSpeed);

    }

}
