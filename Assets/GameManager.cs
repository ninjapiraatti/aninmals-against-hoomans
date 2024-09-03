using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GridManager gridManager;
    void Start()
    {
        Debug.Log("Game Manager runs");
        StartCoroutine(RepeatEveryTenSeconds());
    }

    private IEnumerator RepeatEveryTenSeconds()
    {
        while (true) // Infinite loop
        {
            // Call your method here
            DoSomething();

            // Wait for 10 seconds
            yield return new WaitForSeconds(10f);
        }
    }

    private void DoSomething()
    {
        // Your logic here
        Debug.Log("This happens every 10 seconds!");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
