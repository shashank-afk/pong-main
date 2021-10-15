using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncysurface : MonoBehaviour
{
    public float Bouncestrength ;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        uniball ball = collision.gameObject.GetComponent<uniball>();
        if(ball!=null)
        {
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.Bouncestrength);
        }
    }
}
