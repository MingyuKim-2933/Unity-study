// 멀티미디어공학과/2016113290/김민규/2021-03-15/AM 11시 50분

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode2 : MonoBehaviour
{
    float GetDiff(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4) // 4개의 점의 좌표를 메소드의 입력으로 받아 앞 두개의 점의 거리와 뒤 두개의 점의 거리의 차를 반환하는 메소드
    {
        float width1 = x2 - x1;  // 앞의 두 개 좌표의 가로길이
        float height1 = y2 - y1; // 앞의 두 개 좌표의 세로길이
        float width2 = x4 - x3; // 뒤의 두 개 좌표의 가로길이
        float height2 = y4 - y3; // 뒤의 두 개 좌표의 세로길이

        float distance1 = width1 * width1 + height1 * height1; 
        distance1 = Mathf.Sqrt(distance1); // 앞의 두 개 좌표의 거리

        float distance2 = width2 * width2 + height2 * height2;
        distance2 = Mathf.Sqrt(distance2); // 뒤의 두 개 좌표의 거리

        float diff = Mathf.Abs(distance1 - distance2); // 두 거리의 차를 계산한 후 절대값을 구해준다.

        return diff; // 두 거리의 차의 절대값을 반환한다.
    }

    void PrintScore() // 20개의 랜덤한 점수에 대해 점수와 학점을 출력하는 메소드
    {
        int[] students = new int[20]; // 크기 20의 배열을 생성한다.

        for(int i = 0; i < students.Length; i++) // 배열의 크기인 20번만큼 반복한다.
        {
            students[i] = Random.Range(50, 101); // 50부터 100점 사이의 랜덤한 값 20개를 학생들의 점수로 할당한다.
        }

        for (int i = 0; i < students.Length; i++) // 배열의 크기인 20번만큼 반복한다.
        {
            if (students[i] >= 90) // 학생의 점수가 90점 이상이면 A를 출력한다.
            {
                Debug.Log((i) + "번 학생의 점수는 " + students[i] + " 학점은 A");
            }

            else if (students[i] >= 80) // 학생의 점수가 80점 이상이면 B를 출력한다.
            {
                Debug.Log((i) + "번 학생의 점수는 " + students[i] + " 학점은 B");
            }

            else if (students[i] >= 70) // 학생의 점수가 70점 이상이면 C를 출력한다.
            {
                Debug.Log((i) + "번 학생의 점수는 " + students[i] + " 학점은 C");
            }

            else if (students[i] >= 60) // 학생의 점수가 60점 이상이면 D를 출력한다.
            {
                Debug.Log((i) + "번 학생의 점수는 " + students[i] + " 학점은 D");
            }

            else // 학생의 점수가 59점 이하이면 F를 출력한다.
            {
                Debug.Log((i) + "번 학생의 점수는 " + students[i] + " 학점은 F");
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        float diff = GetDiff(2, 2, 5, 6, 1, 1, 7, 9); // (2,2)에서 (5,6)까지의 거리와 (1,1)에서 (7,9)까지의 거리의 차를 구한다.
        Debug.Log("(2,2)에서 (5,6)까지의 거리와 (1,1)에서 (7,9)까지의 거리의 차 :" + diff); // (2,2)에서 (5,6)까지의 거리와 (1,1)에서 (7,9)까지의 거리의 차를 출력한다.

        PrintScore(); // 20개의 랜덤한 점수에 대해 점수와 학점을 출력한다.
    }
}
