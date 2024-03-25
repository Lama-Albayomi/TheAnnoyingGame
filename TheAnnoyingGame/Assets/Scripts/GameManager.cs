using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour{
    char[,] map = new char[20, 20] {
            // 0    1    2    3    4    5    6    7    8    9   10   11   12   13   14   15   16   17   18   19
            { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },  // 0
            { '#', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#' },  // 1
            { '#', '.', '.', '.', '.', '.', '.', 'P', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#' },  // 2
            { '#', '.', '#', '#', '#', '#', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#' },  // 3
            { '#', '.', '#', '.', '.', '#', '#', '#', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#' },  // 4
            { '#', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#' },  // 5
            { '#', '.', '#', '.', '.', '.', '#', '#', '#', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '#' },  // 6
            { '#', '.', '#', '.', '.', '.', '#', '.', '#', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '#' },  // 7
            { '#', '.', '#', '.', '.', '.', '#', '.', '#', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '#' },  // 8
            { '#', '.', '#', '#', '#', '#', '#', '.', '#', '#', '#', '#', '#', '.', '#', '.', '.', '.', '.', '#' },  // 9
            { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '#' },  // 10
            { '#', '.', '.', '.', '.', '#', '#', '#', '#', '.', '.', '.', '.', '.', '#', '.', '.', '.', '.', '#' },  // 11
            { '#', '.', '.', '.', '.', '.', '.', '.', '#', '#', '#', '#', '#', '#', '#', '.', '.', '.', '.', '#' },  // 12
            { '#', '#', '#', '#', '#', '.', '.', '.', '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#' },  // 13
            { '#', '.', '.', '.', '#', '#', '#', '#', '#', '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#' },  // 14
            { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#' },  // 15
            { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#' },  // 16
            { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#' },  // 17
            { '#', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '#' },  // 18 
            { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }}; // 19
    [SerializeField] private TextMeshProUGUI main;
    [SerializeField] private Vector2 player;
    void Start(){
        PrintMap();
    }

    void Update(){

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)){
            player.y -= 1;
            UpdateMap();
        }
        // Move Down
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)){
            player.y += 1;
            UpdateMap();
        }
        // Move Left
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)){
            player.x -= 1;
            UpdateMap();
        }
        // Move Right
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)){
            player.x += 1;
            UpdateMap();
        }
        
    }
    void PrintMap(){
        for (int i = 0; i < 20; i++){
            for (int j = 0; j < 20; j++){
                
                main.text += map[i, j];

                if (map[i, j] == 'P'){
                    player = new Vector2(i, j);
                    map[i, j] = '.';
                }
            }
            main.text += "\n";
        }
    }
    void UpdateMap(){
        // clear main text 
        main.text = "";
        for (int i = 0; i < 20; i++){
            for (int j = 0; j < 20; j++){
                if (player.x == j && player.y == i){
                    main.text += "P";
                }
                else{
                    main.text += map[i, j];
                }
            }
            main.text += "\n";
        }
    }
    void PlayerMove(){
        // Move Up
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)){
            player.y -= 1;
        }
        // Move Down
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)){
            player.y += 1;
        }
        // Move Left
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)){
            player.x -= 1;
        }
        // Move Right
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)){
            player.x += 1;
        }

    }
}
