using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreator : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    void Start()
    {
        StartCoroutine("Creation");
    }

    IEnumerator Creation()
    {
        while (true)
        {
            Instantiate(cube, gameObject.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2);
        }
    }
}
