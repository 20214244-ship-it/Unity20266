using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class ItemGenerator : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bombPrefab;

    public float span = 1f;
    float delta = 0f;
    private void Update()
    {
        delta += Time.deltaTime;
        if(delta>span)
        {
            GameObject Item= Instantiate(applePrefab);
            float x = Random.Range(-1, 2);
            float z = Random.Range(-1, 2);
            Item.transform.SetParent(transform);
            Item.transform.position= new Vector3(x,5,z);
            delta = 0;
        }
    }
}
