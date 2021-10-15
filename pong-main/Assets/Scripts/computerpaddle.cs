using UnityEngine;

public class computerpaddle : paddle
{
     private Vector2 _direction;

     private void Update()
     {
        if(Input.GetKey(KeyCode.UpArrow))
            {
                _direction = Vector2.up ;
                print("up key is being pressed");
            }
        else if(Input.GetKey(KeyCode.DownArrow))
            {
                _direction = Vector2.down ;
                print("down key is being pressed");
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
