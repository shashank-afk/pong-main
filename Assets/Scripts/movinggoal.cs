using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movinggoal : MonoBehaviour
{
  public List<Transform> points;
  int goalPoint=0;
  public Transform platform;
  public float movespeed = 2;

  private void Update()
  {
      MoveToNextPoint();
  }

  private void MoveToNextPoint()
  {
      platform.position = Vector2.MoveTowards(platform.position,points[goalPoint].position,Time.deltaTime*movespeed);
      if(Vector2.Distance(platform.position,points[goalPoint].position)<0.0000001f)
      {
          if(goalPoint==points.Count-1)
          {
              goalPoint=0;
          }
          else
            goalPoint++;
      }
  }

}
