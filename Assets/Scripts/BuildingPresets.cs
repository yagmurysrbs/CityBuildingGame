using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CreateAssetMenu(fileName = "Building Preset", menuName = "New Building Preset")] 

public class BuildingPresets : ScriptableObject
{
    public string displayName;
    public int cost;
    public int costPerTurn;
    public GameObject prefab;
    public int population;
    public int jobs;
    public int food;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
