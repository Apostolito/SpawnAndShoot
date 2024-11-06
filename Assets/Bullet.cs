using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 2;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += Time.deltaTime * speed * transform.forward;
    }
}
