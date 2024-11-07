using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float horizontalSpeed;

    [SerializeField] private float leftBorder;
    [SerializeField] private float rightBorder;

    void Update()
    {
        float zDelta = transform.position.z + (speed * Time.deltaTime);

        float horizontal = Input.GetAxisRaw("Horizontal");

        float xDelta = transform.position.x + (horizontal * horizontalSpeed * Time.deltaTime);

        if (xDelta < leftBorder)
        {
            xDelta = leftBorder;
        }
        else if (xDelta > rightBorder)
        {
            xDelta = rightBorder;
        }
        else
        {
            Debug.Log("Ничего");
        }

        transform.position = new Vector3(xDelta, transform.position.y, zDelta);
    }
}
