using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FavoritePlaces : MonoBehaviour
{
    bool placeObjects = false;
    bool bossAllowed = false;
    public static bool enemyWipe = false;
    public int increment = 0;
    // public int mood = 0;
    public static string wanted = "";
    public static bool metAmount=false;
    public TMP_Text txt3;
    public TMP_Text txt;
    public TMP_Text txt2;
    public TMP_Text txt4;
    public GameObject obj;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject objB;
    public GameObject obj2B;
    public GameObject obj3B;
    int max = 0;
    float time = 0;
    int score;
    string[] placesArray = { "Barn", "Mill", "Tractor" };
    string[] placesArray2 = { "Barn", "Mill", "Tractor" };
    float rng;
    int rng2;
    int rng3;
    int rng4;
    int rng5;
    string search = "";
    public static int num;
    // Start is called before the first frame update
    void Start()
    {
        rng = Random.Range(1, 3.4f);
        rng2 = Mathf.RoundToInt(rng);
        rng = Random.Range(1, 3.4f);

        rng4 = Mathf.RoundToInt(rng);
        rng = Random.Range(1, 3.4f);
        rng5 = Mathf.RoundToInt(rng);
        if (rng5 == 1)
        {
            wanted = "Chicken";
        }
        if (rng5 == 2)
        {
            wanted = "Cow";
        }
        if (rng5 == 3)
        {
            wanted = "Sheep";
        }
    }

    // Update is called once per frame
    void Update()
    {
        search = "Wanted " + wanted + "\n" + EnemyDamage.wantedNum + " out of " + rng4 + max;

        txt4.SetText("Wanted " + wanted + "\n" + EnemyDamage.wantedNum + " out of " + rng4 + max);
        score = Scoring.score;
        // Debug.Log(mood+"mood");

        time += Time.deltaTime;
        if (rng2 == 1)
        {
            obj.SetActive(true);

        }
        if (rng2 == 2)
        {
            obj2.SetActive(true);
        }
        if (rng2 == 3)
        {
            obj3.SetActive(true);
        }
        if (time > 30)
        {
            placeObjects = true;
        }
        Debug.Log("num" + EnemyDamage.wantedNum);
        if (rng3 != 0)
            txt2.SetText(placesArray2[rng3 - 1]);
        if (placeObjects && !BossAI.bossAppeared && search.Contains("" + rng4 + max)&&metAmount)
        {
            EnemyDamage.wantedNum = 0;
            bossAllowed = true;
            max += 1;

            //  if(score >mood+15&&Scoring.score !>mood+30){
            //     Debug.Log("success");
            //     txt3.SetText("Mood: Fired Up/n Effect: Movement Speed Up");
            // }
            // if(score >mood+30){
            // txt3.SetText("Mood: Epic/n Effect:Shots pass enemies");
            // }
            // Debug.Log(mood+"difference"+score);
            // mood=score;
            objB.SetActive(false);
            obj2B.SetActive(false);
            obj3B.SetActive(false);
            obj.SetActive(false);
            obj2.SetActive(false);
            obj3.SetActive(false);
            time = 0;
            rng = Random.Range(1, 3.4f);
            rng2 = Mathf.RoundToInt(rng);
            rng = Random.Range(1, 3.4f);

            rng3 = Mathf.RoundToInt(rng);
            rng4 = Mathf.RoundToInt(rng);
            rng = Random.Range(1, 3.4f);
            rng5 = Mathf.RoundToInt(rng);
            if (rng3 == 1)
            {
                objB.SetActive(true);

            }
            if (rng3 == 2)
            {
                obj2B.SetActive(true);
            }
            if (rng3 == 3)
            {
                obj3B.SetActive(true);
            }
            if (rng5 == 1)
            {
                wanted = "Chicken";
            }
            if (rng5 == 2)
            {
                wanted = "Cow";
            }
            if (rng5 == 3)
            {
                wanted = "Sheep";
            }
            placeObjects = false;
            metAmount=false;
        }
        num=rng4+max;
    }
}
