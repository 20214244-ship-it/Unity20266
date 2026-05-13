using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    public float throwForce = 10f;
    public float startY;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startY = Input.mousePosition.y;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            GameObject bamsoni = Instantiate(bamsongiPrefab);
            bamsoni.transform.position = transform.position;

            float power = Input.mousePosition.y - startY;

            Vector3 dir = transform.forward + transform.up * 0.5f;
            bamsoni.GetComponent<BamsongiCintroller>().Shoot(dir * power * throwForce);

            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //bamsoni.GetComponent<BamsongiCintroller>().Shoot(ray.direction * 2000);
        }
    }
}
