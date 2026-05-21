using UnityEngine;
using UnityEngine.AI;

public class ItmeGenerator : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bombPrefab;
    public float span = 1f;
    float delta = 0f;
    public int ratio = 3; // 30% 폭탄비율
    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if(delta > span)
        {
            int dice = Random.Range(0,10);
            GameObject item;
            if(dice<ratio)
            {
                item = Instantiate(bombPrefab);
            }
            else
            {
                item = Instantiate(applePrefab);
            }
            //GameObject item = Instantiate(applePrefab);
            float x = Random.Range(-1, 2);
            float z = Random.Range(-1, 2);
            item.transform.position = new Vector3(x, 5, z);
            delta = 0;
        }

    }
}
