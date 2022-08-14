using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFindingUpdater : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DestructableCrate.OnAnyDestroyed += DestructableCrate_OnAnyDestroyed;
    }

    private void DestructableCrate_OnAnyDestroyed(object sender, EventArgs e)
    {
        DestructableCrate destructableCrate = sender as DestructableCrate;

        Pathfinding.Instance.SetIsWalkableGridPosition(destructableCrate.GetGridposition(), true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
