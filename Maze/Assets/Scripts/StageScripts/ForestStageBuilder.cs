using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ForestStageBuilder : MonoBehaviour,IStageBuilder
{
    public GameObject parentOfStage;
    public GameObject terrain;
    public GameObject TreeObj;
    public GameObject plantObj;
    public GameObject monster;
    private Stage _stage = null;
    public Stage GetStage()
    {
        return _stage;
    }
    public void MakeStage()
    {
        GameObject obj = Instantiate(parentOfStage) as GameObject;
        _stage = obj.GetComponent<Stage>();
        _stage.SetStageType(StageType.Forest);
    }
    public void SetTerrain()
    {
        _stage.AddObject(terrain, new Vector3(0, -0.5f, 0));
    }
    public void SetObject()
    {
        _stage.AddObject(TreeObj, new Vector3(-5, 0, 0));
        _stage.AddObject(TreeObj, new Vector3(4, 0, 3));
        _stage.AddObject(plantObj, new Vector3(-2, 0.7f, -2.8f));
        _stage.AddObject(plantObj, new Vector3(3.7f, 0.75f, 0));
    }
    public void SetMonster()
    {
        _stage.AddObject(monster, new Vector3(6f, 0, -1.3f));
    }
}
