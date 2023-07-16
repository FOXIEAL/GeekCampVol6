using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreator : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private GameObject upcube;
    [SerializeField] private GameObject heart;
    [SerializeField] private GameObject star;
    [SerializeField] private GameObject goal;

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
    private List<Vector3> starPositionList = new List<Vector3>() {
        new Vector3(1.5f,1f,50f),
        new Vector3(1.5f,1f,50f),
        new Vector3(-1.5f,1f,50f),
        new Vector3(1.5f,1f,50f),
        new Vector3(1.5f,1f,50f),
        new Vector3(1.5f,1f,50f),
        new Vector3(-1.5f,1f,50f),
        new Vector3(-1.5f,1f,50f),
        new Vector3(1.5f,-5f,50f),
        new Vector3(-1.5f,1f,50f),
    };
    private List<Vector3> upcubuPositionList = new List<Vector3>() {
        new Vector3(0,1.9f,50f),
        new Vector3(0,1.9f,50f),
        new Vector3(-1f,1f,0f),
        new Vector3(-3f,1f,0f),
        new Vector3(2f,1f,0f),
    };
    private List<Vector3> heartPositionList = new List<Vector3>() {
        new Vector3(2f,1f,50f),
        new Vector3(-1f,1f,50f),
        new Vector3(-1f,1f,50f),
        new Vector3(2f,1f,50f),
        new Vector3(-1.5f,-5f,50f),
    };

    private Vector3 goalVec = new (0.16f,2f,50f);
    
    private int index = 0;

    public void CoroutineStart()
    {
        StartCoroutine("Creation");
    }

    IEnumerator Creation()
    {
        // Instantiate(cube, cubuPositionList[0], Quaternion.identity);
        // Instantiate(upcube, upcubuPositionList[0], Quaternion.identity);
        // Instantiate(heart, heartPositionList[0], Quaternion.identity);
        // Instantiate(star, starPositionList[0], Quaternion.identity);
        // yield return new WaitForSeconds(2);
        
        Instantiate(cube, cubuPositionList[0], Quaternion.identity);
        Instantiate(star, starPositionList[0], Quaternion.identity);
        yield return new WaitForSeconds(2);
        
        Instantiate(cube, cubuPositionList[1], Quaternion.identity);
        Instantiate(star, starPositionList[1], Quaternion.identity);
        yield return new WaitForSeconds(2);
        
        Instantiate(cube, cubuPositionList[2], Quaternion.identity);
        Instantiate(star, starPositionList[2], Quaternion.identity);
        yield return new WaitForSeconds(2);
        
        Instantiate(cube, cubuPositionList[3], Quaternion.identity);
        Instantiate(heart, heartPositionList[0], Quaternion.identity);
        yield return new WaitForSeconds(2);
        
        Instantiate(cube, cubuPositionList[4], Quaternion.identity);
        Instantiate(heart, heartPositionList[1], Quaternion.identity);
        yield return new WaitForSeconds(2);
        
        Instantiate(upcube, upcubuPositionList[0], Quaternion.identity);
        Instantiate(star, starPositionList[3], Quaternion.identity);
        yield return new WaitForSeconds(2);
        
        Instantiate(cube, cubuPositionList[6], Quaternion.identity);
        Instantiate(star, starPositionList[4], Quaternion.identity);
        yield return new WaitForSeconds(2);
        
        Instantiate(cube, cubuPositionList[7], Quaternion.identity);
        Instantiate(heart, heartPositionList[2], Quaternion.identity);
        yield return new WaitForSeconds(2);
        
        Instantiate(cube, cubuPositionList[8], Quaternion.identity);
        Instantiate(star, starPositionList[5], Quaternion.identity);
        yield return new WaitForSeconds(2);
        
        Instantiate(upcube, upcubuPositionList[1], Quaternion.identity);
        Instantiate(cube, cubuPositionList[9], Quaternion.identity);
        Instantiate(star, starPositionList[6], Quaternion.identity);
        yield return new WaitForSeconds(2);
        
        Instantiate(goal, goalVec, Quaternion.identity);
    }

    private Vector3 GetPosition(List<Vector3> positionList) {
        Vector3 position = positionList[index];
        return position;

    }

}
