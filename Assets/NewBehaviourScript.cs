using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity");
        
        // 1. 변수
        int level = 5;
        float strength = 15.5f;
        string playerName = "junyoung";
        bool isFullLevel = false;

        // 2. 그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 10;
        monsterLevel[2] = 20;
        
        Debug.Log("맵에 존재하는 몬스터의 레벨");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);

        List<string> items = new List<string>();
        items.Add("HP potion");
        items.Add("MP potion");
        
        // 3. 연산자
        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        int nextExp = 300 - (exp % 300);

        string title = "전설의";
        string fullName = title + " " + playerName;
        
        int fullLevel = 99;
        isFullLevel = level == fullLevel;

        bool isEndTutorial = level > 10;
        
        int health = 30;
        int mana = 25;
        bool isBadCondition = health <= 50 || mana <= 20;
        
        string condition = isBadCondition ? "나쁨" : "좋음";
        
        // 4. 키워드
        // int float string bool new List

        // 5. 조건문
        if (condition == "나쁨") {
            Debug.Log("플레이어의 상태가 나쁘니 아이템을 사용하세요.");
        } else {
            Debug.Log("플레이어의 상태가 좋습니다.");
        }
        
        if (!isBadCondition && items[0] == "HP potion") {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("체력 물약 30을 사용하였습니다.");
        } else if (!isBadCondition && items[1] == "MP potion") {
            items.RemoveAt(1);
            mana += 30;
            Debug.Log("마나 물약 30을 사용하였습니다.");
        }

        switch (monsters[0]) {
            case "슬라임":
            case "사막뱀":
                Debug.Log("소형 몬스터 출현!");
                break;
            case "악마":
                Debug.Log("중형 몬스터 출현!");
                break;
            case "골렘":
                Debug.Log("대형 몬스터 출현!");
                break;
            default:
                Debug.Log("??? 몬스터 출현!");
                break;
        }

        // 6. 반복문
        while (health > 0) {
            health--;
            if (health > 0) Debug.Log("독 데미지를 입었습니다. 현재 체력: " + health);
            else Debug.Log("사망하였습니다");
            
            if (health == 10) {
                Debug.Log("해독제를 사용합니다.");
                break;
            }
        }

        for (int i = 0; i < 10; i++) {
            health++;
            Debug.Log("붕대로 치료 중..." + health);
        }

        foreach (string monster in monsters) {
            Debug.Log("이 지역에 있는 몬스터: " + monster);
        }
    }
}
