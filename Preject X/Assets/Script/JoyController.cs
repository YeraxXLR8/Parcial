using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoyController : Controller,IDragHandler,IEndDragHandler
{
    Vector3 moveDir;
    Vector3 initJoyPos;
    private void Awake()
    {
        initJoyPos = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        moveDir = Vector3.ClampMagnitude((Vector3)eventData.position - initJoyPos, 45);
        transform.position = moveDir + initJoyPos;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        moveDir = Vector3.zero;
        transform.position = initJoyPos;
    }

    public override Vector3 MoveDir()
    {
        Vector3 newVector = moveDir.normalized;
        return new Vector3(newVector.x,0,newVector.y);
    }

    
}
