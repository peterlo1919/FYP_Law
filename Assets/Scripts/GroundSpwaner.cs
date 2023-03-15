using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpwaner : MonoBehaviour
{
    public GameObject groundTile;
    Vector3 nextSpwanPoint;
    // Start is called before the first frame update
    public void SpwanTile()
    {
        GameObject temp = Instantiate(groundTile, nextSpwanPoint, Quaternion.identity); ;
        nextSpwanPoint = temp.transform.GetChild(1).transform.position;
    }

    private void Start()
    {
        for(int i = 0;i < 15;i++)
        {
            SpwanTile();
        }
    }
}
