using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; // unity editor 관련 api를 사용하기위해 선언

public class MyEditorWindow : EditorWindow
{
    // 만든 editor window를 오픈을 해줄 함수 선언, static 선언
    // unity editor의 메뉴에서 메뉴창을 선택하면 해당 함수가 실행(호출된다.)
    //MenuItem에서 %g는 단축키를 의미하며 crtl + g를 의미한다.
    // 참고 블로그 https://debuglog.tistory.com/28
    [MenuItem("MyTool/Open MyTool %g")]
    static void Open()
    {
        Debug.Log("My Tool 창 열림");

        // window 창 생성
        var window = GetWindow<MyEditorWindow>();
        window.title = "My Tool";
    }
}
