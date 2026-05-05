using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class artController : MonoBehaviour
{
    // so that this stupid thing is found
    public static artController instance;

    public GameObject line;

    public bool mouseDown;
    public List<GameObject> lines;
    
    LineRenderer currentLine;

 void Awake()
    {
            if (instance == null)
        {
            instance = this;
           // DontDestroyOnLoad(gameObject); -> can't do this already another gameManager in other scene UGHHH
        }
        else
        {
            Destroy(gameObject); // Prevent duplication not that im gonna hv that problem lolll sm1 help me
        }
           
    }


    void Start()
    {
        currentLine = GetComponent<LineRenderer>();
        mouseDown = false;
        // set up the list 
        lines = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MouseClick(UnityEngine.InputSystem.InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.performed)
        {
            mouseDown = true;
            
           
             // Reset the line
            //line.positionCount = 0;

            // reSet starting point
           //Vector3 startPos = GetWorldPositionFromMouse();
           // startPos.z = 0f;

          //  line.positionCount = 1;
           // line.SetPosition(0, startPos);

           // prevPos = startPos;
                 
        }
        else
        {
            mouseDown = false;
             GameObject newLine = Instantiate(line); // store my new line

            // the line the player is drawing with is the new one

            newLine.GetComponent<Drawing>().playerLine = true; 

            // add my new line
            lines.Add(newLine); 

            // // make a new line
            // Instantiate(line);
            // line.GetComponent<Drawing>().playerLine = true;
            // lines.Add(line);

            
            StartCoroutine(Timer());
            
        }
    }

      IEnumerator Timer()
    {
        yield return new WaitForSeconds(4f);
        // if i cause an error...
        if(lines.Count >= 1)
        {
              Destroy(lines[0]);
            lines.RemoveAt(0);
        }
     
         
    }


}
