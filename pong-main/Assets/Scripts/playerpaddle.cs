using UnityEngine;

public class playerpaddle : paddle
{
     private Vector2 _direction;

     private void Update()
     {
        if(Input.GetKey(KeyCode.W))
            {
                _direction = Vector2.up ;
                print("W is being pressed");
            }
        else if(Input.GetKey(KeyCode.S))
            {
                _direction = Vector2.down ;
                print("S is being pressed");
            }
        else
        {
            _direction = Vector2.zero ;
        }
         
     }

     private void FixedUpdate()
     {
         if(_direction.sqrMagnitude != 0)
            {
                _rigidbody.AddForce(_direction * this.speed);
            }
     }
}
