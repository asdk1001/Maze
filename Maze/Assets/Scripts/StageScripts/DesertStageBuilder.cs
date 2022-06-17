using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DesertStageBuilder : MonoBehaviour, IStageBuilder
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
        _stage.SetStageType(StageType.Desert);
    }
    public void SetTerrain()
    {
        _stage.AddObject(terrain, new Vector3(0, -0.5f, 0));
    }
    public void SetObject()
    {
        _stage.AddObject(TreeObj, new Vector3(-7.9f, 0, -9));
        _stage.AddObject(TreeObj, new Vector3(0.5f, 2.3f, 3.8f));
        _stage.AddObject(plantObj, new Vector3(0, 0, -2.9f));
    }
    public void SetMonster()
    {
        _stage.AddObject(monster, new Vector3(6f,0,-1.3f));
    }
}
