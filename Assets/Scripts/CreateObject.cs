using System.Collections;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    [SerializeField] float coodinateY = 5.5f;
    [SerializeField] float secondWait = 2f;
    [SerializeField] GameObject[] objects;
    [SerializeField] Transform firstCoordinate;
    [SerializeField] Transform secondCoordinate;

    private void Start()
    {
        StartCoroutine(CreatePrefab());

    }

    IEnumerator CreatePrefab()
    {
        while (true)
        {
            float randCoordinate = Random.Range(firstCoordinate.position.x, secondCoordinate.position.x);
            Instantiate(objects[0], new Vector2(randCoordinate, coodinateY), Quaternion.identity);
            yield return new WaitForSeconds(secondWait);
        }
    }
}
