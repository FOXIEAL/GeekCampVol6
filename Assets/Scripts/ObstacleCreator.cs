using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreator : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private GameObject upcube;
    [SerializeField] private GameObject heart;
    [SerializeField] private GameObject star;

    private List<Vector3> cubuPositionList = new List<Vector3>() {
        new Vector3(-1.5f,1f,50f),
        new Vector3(-1.5f,1f,50f),
        new Vector3(1.5f,1f,50f),
        new Vector3(-1.5f,1f,50f),
        new Vector3(1.5f,1f,50f),
        new Vector3(-1.5f,1f,50f),
        new Vector3(-1.5f,1f,50f),
        new Vector3(1.5f,1f,50f),
        new Vector3(-1.5f,1f,50f),
        new Vector3(1.5f,1f,50f),
    };
    // private List<Vector3> upcubuPositionList = new List<Vector3>() {
    //     new Vector3(-2f,1f,0f),
    //     new Vector3(1f,1f,70f),
    //     new Vector3(-1f,1f,0f),
    //     new Vector3(-3f,1f,0f),
    //     new Vector3(2f,1f,0f),
    // };
    private List<Vector3> haertPositionList = new List<Vector3>() {
        new Vector3(2f,-5f,50f),
        new Vector3(-1f,-5f,50f),
        new Vector3(2f,-5f,50f),
        new Vector3(2f,1f,50f),
        new Vector3(-1.5f,-5f,50f),
        new Vector3(2f,-5f,50f),
        new Vector3(-1f,-5f,50f),
        new Vector3(2f,-5f,50f),
        new Vector3(2f,1f,50f),
        new Vector3(-1.5f,-5f,50f),
    };
    private List<Vector3> starPositionList = new List<Vector3>() {
        new Vector3(1.5f,1f,50f),
        new Vector3(1.5f,1f,50f),
        new Vector3(-1.5f,1f,50f),
        new Vector3(1.5f,-5f,50f),
        new Vector3(-1.5f,1f,50f),
        new Vector3(1.5f,1f,50f),
        new Vector3(1.5f,1f,50f),
        new Vector3(-1.5f,1f,50f),
        new Vector3(1.5f,-5f,50f),
        new Vector3(-1.5f,1f,50f),
    };
    private int index = 0; 
    // void Start()
    // {
    //     StartCoroutine("Creation");
    // }
    
    public void CoroutineStart()
    {
        StartCoroutine("Creation");
    }

    IEnumerator Creation()
    {
        while (true)
        {
            Vector3 cubuposition = GetPosition(cubuPositionList);
            Instantiate(cube, cubuposition, Quaternion.identity);

            // Vector3 upcubuposition = GetPosition(upcubuPositionList);
            // Instantiate(upcube, upcubuposition, Quaternion.identity);

            Vector3 heartposition = GetPosition(haertPositionList);
            Instantiate(heart, heartposition, Quaternion.identity);

            Vector3 starposition = GetPosition(starPositionList);
            Instantiate(star, starposition, Quaternion.identity);
            yield return new WaitForSeconds(2);
            index++;
        }
    }

    private Vector3 GetPosition(List<Vector3> positionList) {
        Vector3 position = positionList[index];
        return position;

    }

}
