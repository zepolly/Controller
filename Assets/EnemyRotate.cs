using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class EnemyRotate : MonoBehaviour
{
    public Transform plaer;
    private int speed = 1;
    private float step;
    public Vector3 distance;
    private Vector3 direction;
    void Awake()
    {
        plaer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        direction = plaer.position - distance;
        step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, direction, step);
        transform.LookAt(plaer);
    }

}
