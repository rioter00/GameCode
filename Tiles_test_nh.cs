using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
struct MockTile
{
    public Vector2 doorPos { get; }
    public int enemies { get; }
    public bool hasBoss { get; }
    public MockTile(Vector2 doorPos, int enemies, bool hasBoss)
    {
        this.doorPos = doorPos;
        this.enemies = enemies;
        this.hasBoss = hasBoss;
    }
}

public class Tiles_test_nh : MonoBehaviour
{
    public Dictionary<Vector2, bool> tileSet1 = new Dictionary<Vector2, bool>();
    Dictionary<Vector2, MockTile> tileSet2 = new Dictionary<Vector2, MockTile>();

    // Start is called before the first frame update
    void Start()
    {
        init1();

        // couldn't you combine the tasks of assigning titles with the data of the data?
        //init2();
    }


    void init1()
    {
        for (int i = 0; i < 1000; i++)
        {
            for (int j = 0; j < 1000; j++)
            {
                var tempTilePos = new Vector2(i, j);
                var tempState = Random.Range(0, 1) == 1 ? true : false;
                tileSet1.Add(tempTilePos, tempState);
            }
        }
        var randTile = new Vector2Int(Random.Range(0, 1000), Random.Range(0, 1000));
        Debug.Log("Tile: " + randTile + " : " + checkTitle(randTile));
    }

    void init2()
    {
        for (int i = 0; i < 1000; i++)
        {
            for (int j = 0; j < 1000; j++)
            {
                var tempTilePos = new Vector2(i, j);
                var tempTile = new MockTile(Vector2.up, 2, false);
                tileSet2.Add(tempTilePos, tempTile);
            }
        }
        var randTile = new Vector2Int(Random.Range(0, 1000), Random.Range(0, 1000));
        Debug.Log("Tile: " + randTile + " : " + tileSet2[randTile].doorPos + " : " + tileSet2[randTile].doorPos + " : " + tileSet2[randTile].hasBoss);
        Debug.Log("Tile Count: " + tileSet2.Count);
    }

    bool checkTitle(Vector2 pos)
    {
        if (tileSet1.ContainsKey(pos))
        {
            return tileSet1[pos];
        }
        else
        {
            return false;
        }
    }
}
