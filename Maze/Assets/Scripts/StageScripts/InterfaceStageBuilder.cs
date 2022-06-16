using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum StageType
{
    Forest,
    Desert
}
interface IStageBuilder
{
    Stage GetStage();
    void SetTerrain();
    void SetObject();
    void SetMonster();
}
