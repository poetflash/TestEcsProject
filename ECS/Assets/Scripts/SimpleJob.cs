using Unity.Jobs;
using UnityEngine;

public struct SimpleJob : IJob
{
    public float a, b;
    
    public void Execute()
    {
        float result = a + b;
        
        Debug.Log(result);
    }
}
