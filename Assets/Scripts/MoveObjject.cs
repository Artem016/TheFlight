using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjject : MonoBehaviour
{
    public float speed = 3;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}