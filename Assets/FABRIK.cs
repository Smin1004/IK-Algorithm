using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class unit
{
    public Transform head;
    public Transform tail;
    public float betweenLength;

    public unit(Transform _head, Transform _tail)
    {
        head = _head;
        tail = _tail;
        betweenLength = (head.position - tail.position).magnitude;
    }
}

public class FABRIK : MonoBehaviour
{
    [SerializeField] List<GameObject> units = new();
    List<unit> unitList = new();

    public Transform target;
    float betweenLength;

    private void Awake()
    {
        for (int i = 0; i < units.Count - 1; i++) unitList.Add(new unit(units[i].transform, units[i + 1].transform));
    }

    void Update()
    {

    }

    void Reach(Transform head, Transform tail, float between)
    {
        Vector3 dir = (head.position - tail.position).normalized;
        
    }
}
