using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreator : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private GameObject star;
    [SerializeField] private GameObject heart;
    
    private List<Vector3> positionList = new List<Vector3>() {
        new Vector3(5f,1f,25f),
        new Vector3(1f,1f,25f),
        new Vector3(0f,1f,25f),
        new Vector3(-3f,1f,25f),
        new Vector3(2f,1f,25f),
    };
    private int index = 0;
    void Start()
    {
        StartCoroutine("Creation");
    }

    IEnumerator Creation()
    {
        while (true)
        {
            Vector3 position = GetPosition();
            Instantiate(cube, position, Quaternion.identity);
            yield return new WaitForSeconds(2);
        }
    }

    private Vector3 GetPosition() {
        Vector3 position = positionList[index];
        index++;
        return position;

    }

}
