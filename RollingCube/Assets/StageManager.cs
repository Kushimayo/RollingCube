using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour {
    public GameObject[] arrayObjects;
    public GameObject baseStageObject;
    public GameObject[] activeObjects;
    public int arraySize;

    void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }

    // Use this for initialization
    void Start () {
        baseStageObject = GameObject.Find("BaseStage");
        arrayObjects = GameObject.FindGameObjectsWithTag("StageShapes");
        arraySize = arrayObjects.Length;

        activeObjects = new GameObject[3];
        activeObjects[0] = baseStageObject;
        activeObjects[1] = selectNextStage();
    }

    GameObject selectNextStage()
    {
        int NextStageNumber = Random.Range(0, arraySize - 1);
        return Instantiate(arrayObjects[NextStageNumber], 
            new Vector3(arrayObjects[NextStageNumber].transform.position.x, arrayObjects[NextStageNumber].transform.position.y, arrayObjects[NextStageNumber].transform.position.z),
            Quaternion.identity);
    }

    void UpdateStage()
    {
        Destroy(activeObjects[0]);
        activeObjects[0] = activeObjects[1];
        activeObjects[1] = selectNextStage();
    }

    // Update is called once per frame
    void Update () {
		for (int i = 0; i < activeObjects.Length; i++)
        {
            activeObjects[i].SendMessage("MoveStageNomal");
        }
	}
}
