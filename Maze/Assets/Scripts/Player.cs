using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    private bool isGreenKey;

    public bool IsGreenKey { get => isGreenKey; set => isGreenKey = value; }

    Stack<CommandKey> stack = new Stack<CommandKey>();

    public void OnClickedUndoBtn()
    {
        if (stack.Count > 0)
        {
            CommandKey command = stack.Pop();
            command.Undo();
        }

    }

    void Start()
    {
        IsGreenKey = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
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
        }
    }
}
