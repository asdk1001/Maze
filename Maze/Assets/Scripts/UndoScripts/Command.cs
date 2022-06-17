using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CommandKey
{
    public GameObject player;
    public virtual void Excute(int flag) { }
    public virtual void Undo(){ }
}

public class CommandUpDown : CommandKey
{
    Vector3 prevPos;

    public CommandUpDown(GameObject obj)
    {
        this.player = obj;
    }
    public override void Excute(int flag)
    {
        Updown(flag);
    }
    void Updown(int flag)
    {
        prevPos = player.transform.position;

        player.transform.Translate(new Vector3(0, 0, flag));
    }
    public override void Undo()
    {
        player.transform.position = prevPos;
    }
}

public class CommandLeftRight : CommandKey
{
    Vector3 prevPos;

    public CommandLeftRight(GameObject obj)
    {
        this.player = obj;
    }
    public override void Excute(int flag)
    {
        LeftRight(flag);
    }
    void LeftRight(int flag)
    {
        prevPos = player.transform.position;

        player.transform.Translate(new Vector3(flag, 0, 0));
    }
    public override void Undo()
    {
        player.transform.position = prevPos;
    }
}
