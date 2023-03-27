using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpwaner groundSpwaner;
    public GameObject objectPrefab;
    // Start is called before the first frame update
    private void Start()
    {
        groundSpwaner = GameObject.FindObjectOfType<GroundSpwaner>();
        SpwanObject();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            groundSpwaner.SpwanTile();
            Destroy(gameObject, 1);
        }
    }

    void SpwanObject()
    {
        int objectSpwaner = Random.RandomRange(2, 5);
        Transform spwanPoint = transform.GetChild(objectSpwaner).transform;

        Instantiate(objectPrefab,spwanPoint.position,objectPrefab.transform.rotation, objectPrefab.transform.parent);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
