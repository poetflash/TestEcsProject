using Unity.Jobs;
using UnityEngine;

public class TestJob : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SimpleJob job = new SimpleJob();
        job.Schedule().Complete();
    }
}
