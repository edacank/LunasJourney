using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch : MonoBehaviour
{
    public float witchSpeed;
    private Rigidbody2D rb;
    private Vector2 witchDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        witchDirection = new Vector2(0, directionY).normalized;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, witchDirection.y * witchSpeed);

    }
}
