using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; // unity editor 관련 api를 사용하기위해 선언

public class MyEditorWindow : EditorWindow
{
    #region EditorWindow 다중 생성 방법1

    //static MyEditorWindow window;

    //[MenuItem("MyTool/Open MyTool %g")]
    //static void Open()
    //{
    //    Debug.Log("My Tool 창 열림");

    //    window = CreateInstance<MyEditorWindow>(); // EditorWindow가 생성됨

    //    window.Show();
    //}

    #endregion



    #region 1개의 EditorWindow 생성 방법1

    //static MyEditorWindow window;

    //[MenuItem("MyTool/Open MyTool %g")]
    //static void Open()
    //{
    //    Debug.Log("My Tool 창 열림");

    //     다중 생성을 막으려면 현재 EditorWindow가 생성되었는지 확인
    //    if (window == null)
    //    {
    //        window = CreateInstance<MyEditorWindow>();
    //    }

    //    window.Show();
    //}

    #endregion



    #region 1개의 EditorWindow 생성 방법2

    // 만든 editor window를 오픈을 해줄 함수 선언, static 선언
    // unity editor의 메뉴에서 메뉴창을 선택하면 해당 함수가 실행(호출된다.)
    //MenuItem에서 %g는 단축키를 의미하며 crtl + g를 의미한다.
    // 참고 블로그 https://debuglog.tistory.com/28
    [MenuItem("MyTool/Open MyTool %g")]
    static void Open()
    {
        Debug.Log("My Tool 창 열림");

        // EditorWindow 생성 (한개만 생성됨
        var window = GetWindow<MyEditorWindow>();

        // EditorWindow 이름 설정 (설정안하면 default 값으로 Editor Window가 된다.)
        window.title = "My Tool";
    }
    #endregion

    #region GUI 그리기

    // GUI를 그리기 위해서 EditorWindow에서 재공하는 예약된 OnGUI()를 선언해야함 유니티에서 호출해줌
    private void OnGUI()
    {
        // EditorGUILayout은 값을 설정하기 위한 필드들이 모여있는 클래스이다.
        EditorGUILayout.LabelField("Label!!!");
        EditorGUILayout.TextField("TextField!!!");

        // GUILayout은 대부분 Layout없이 직접 Rect를 지정하여 그리는 필드들이 모여있는 클래스이다.
        GUILayout.Button("Button!!!");

        //GUI
        //EditorGUI
        //GUILayout
        //EditorGUILayout
    }

    #endregion
}
