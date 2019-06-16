using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour
{
    public float SpawnTime = 1f;

    public Vector3 MinOffset;
    public Vector3 MaxOffset;
    public Vector3 MinRotation;
    public Vector3 MaxRotation;

    public GameObject[] Prefabs;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
       
    private void OnEnable()
    {
        StartCoroutine(SpawnRoutine());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private IEnumerator SpawnRoutine()
    {
        while (isActiveAndEnabled)
        {
            yield return new WaitForSeconds(SpawnTime);
            Spawn();
        }
    }

    private void Spawn()
    {
        var prefab = Prefabs[Random.Range(0, Prefabs.Length)];
        if (!prefab)
            return;

        Vector3 position = (new Vector3(Random.Range(MinOffset.x, MaxOffset.x),
                                        Random.Range(MinOffset.y, MaxOffset.y),
                                        0f));
        var rotation = Quaternion.Euler(new Vector3(
            Random.Range(MinRotation.x, MaxRotation.x),
            Random.Range(MinRotation.y, MaxRotation.y),
            Random.Range(MinRotation.z, MaxRotation.z)));

        Instantiate(prefab, position, rotation);
    }
}
