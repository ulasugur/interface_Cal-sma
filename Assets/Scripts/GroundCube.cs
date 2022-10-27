using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCube : MonoBehaviour, Iclickable
{
    [SerializeField] private GameObject Tower;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void click()
    {
        SpawnTower();
    }
    void SpawnTower()
    {
        Instantiate(Tower,gameObject.transform.position,Quaternion.identity);
    }
}
