using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float horizontalSpeed;

    [SerializeField] private float leftBorder;
    [SerializeField] private float rightBorder;

    private float distance = 60;


    [SerializeField] private float spawnDist = 120;
    [SerializeField] private GameObject road;

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

        if (zDelta > distance) {
            distance += 60;
            Instantiate(road, 
                new Vector3(0, 0, distance + spawnDist), 
                Quaternion.identity);
        }

        Debug.Log("Test");

        transform.position = new Vector3(xDelta, transform.position.y, zDelta);
    }
}
