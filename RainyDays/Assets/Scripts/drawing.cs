using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Drawing : MonoBehaviour
{
    private LineRenderer line;
    private Camera mainCamera;

    public bool playerLine;

    //bool mouseDown;

    Vector3 prevPos;
    float minDis = 0.1f;

   

    void Start()
    {
        playerLine = false;
        line = GetComponent<LineRenderer>();
        prevPos = transform.position;

        mainCamera = Camera.main;
       

    }
    void Update()
    {
        if(playerLine == true)
        {
            Vector3 currentPos = GetWorldPositionFromMouse();
            currentPos.z = 0f;
            
            if(Vector3.Distance(currentPos, prevPos) > minDis && artController.instance.mouseDown == true) // losing it rn
            {
                line.positionCount++;
                line.SetPosition(line.positionCount - 1, currentPos);
            }
        }
  //Vector3 currentPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
    }

    private Vector2 GetWorldPositionFromMouse()
    {
         Vector2 mousePos = Mouse.current.position.ReadValue();
        return mainCamera.ScreenToWorldPoint(mousePos);
    }

    // public void MouseClick(UnityEngine.InputSystem.InputAction.CallbackContext callbackContext)
    // {
    //     if (callbackContext.performed)
    //     {
           
    //          // Reset the line
    //         line.positionCount = 0;

    //         // reSet starting point
    //         Vector3 startPos = GetWorldPositionFromMouse();
    //         startPos.z = 0f;

    //         line.positionCount = 1;
    //         line.SetPosition(0, startPos);

    //         prevPos = startPos;
                 
    //     }
    //     else
    //     {
    //         mouseDown = false;
    //         //StartCoroutine(Timer());
            
    //     }
    // }


    
    //  IEnumerator Timer()
   // {
        //yield return new WaitForSeconds(2f);
         
   // }


   

}
