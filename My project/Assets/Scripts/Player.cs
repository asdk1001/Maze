using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Stack<CommandKey> stack = new Stack<CommandKey>();

    //bool bChange;
   // CommandKey BtnA, BtnB;

    public void OnClickedUndoBtn()
    {
        if (stack.Count > 0)
        {
            CommandKey command = stack.Pop();
            command.Undo();
        }
            
    }

/*
    private void Start()
    {
        bChange = false;
        OnClickedChangeKeyBtn();
    }

    public void OnClickedChangeKeyBtn()
    {
        if(bChange == false)
        {
            bChange = true;
            BtnA = new CommandLeftRight(this.gameObject);
            BtnB = new CommandUpDown(this.gameObject);
        }
        else
        {
            bChange = false;
            BtnA = new CommandUpDown(this.gameObject);
            BtnB = new CommandLeftRight(this.gameObject);
        }
    }
*/

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            CommandKey command = new CommandLeftRight(this.gameObject);
                stack.Push(command);
            command.Excute(-1);
            //BtnA.Excute(-1);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            CommandKey command = new CommandLeftRight(this.gameObject);
            stack.Push(command);
            command.Excute(1);
            //BtnA.Excute(1);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            CommandKey command = new CommandUpDown(this.gameObject);
            stack.Push(command);
            command.Excute(1);
            //BtnB.Excute(1);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            CommandKey command = new CommandUpDown(this.gameObject);
            stack.Push(command);
            command.Excute(-1);
            // BtnB.Excute(-1);
        }
    }
}
