using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class scoringzone : MonoBehaviour
{   
    public EventTrigger.TriggerEvent scoreTrigger;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        uniball ball = collision.gameObject.GetComponent<uniball>();
        if(ball!=null)
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke(eventData);
        }
    }
}

