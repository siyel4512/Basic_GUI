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



    #region GUI 그리기1

    //// GUI를 그리기 위해서 EditorWindow에서 재공하는 예약된 OnGUI()를 선언해야함 유니티에서 호출해줌
    //private void OnGUI()
    //{
    //    // EditorGUILayout은 값을 설정하기 위한 필드들이 모여있는 클래스이다.
    //    EditorGUILayout.LabelField("Label!!!");
    //    EditorGUILayout.TextField("TextField!!!");

    //    // GUILayout은 대부분 Layout없이 직접 Rect를 지정하여 그리는 필드들이 모여있는 클래스이다.
    //    GUILayout.Button("Button!!!");
    //}

    #endregion



    #region GUI 그리기2

    //private void OnGUI()
    //{
    //    // Layout -> 유니티의 자동 레이아웃 이용하는 형태의 GUI들, 즉 따로 위치를 지정해줄 필요 없음
    //    // GUI / GUILayout : Editor / 런타임용 (빌드후에서 사용가능)
    //    // EditorGUI / EditorGUILayout : Only Editor용

    //    GUI.Label(new Rect(250, 0, 100, 50), "GUI.Label");
    //    EditorGUI.LabelField(new Rect(250, 50, 100, 50), "EditorGUI.LabelField(");

    //    GUILayout.Label("GUILayout.Label");
    //    EditorGUILayout.LabelField("EditorGUILayout.LabelField");
    //}

    #endregion



    #region GUI 그리기3 (사용이 빈번한 GUI 요소 그룹 사용해보기

    int intValue;
    float floatValue;
    Color colorValue;
    Gradient gradientValue = new Gradient();
    Vector3 vector3Value;
    Vector3Int vector3IntValue;
    Rect rectValue;
    UnityEngine.Object objectValue;
    string passwordValue;
    string tagValue;
    UnityEngine.ParticleSystemCollisionType enumValue;
    bool toggleValue;
    string[] stringArr = new string[] { "String01", "String02", "String03", "String04", "String05", "String06"};
    int selectionValue;

    private void OnGUI()
    {
        #region ===:: EditorGUILayout:: ===
        // https://blog.naver.com/PostView.naver?blogId=hammerimpact&logNo=220772494827&parentCategoryNo=&categoryNo=&viewDate=&isShowPopularPosts=false&from=postView

        // int field
        intValue = EditorGUILayout.IntField("int 값", intValue);

        // float field
        floatValue = EditorGUILayout.FloatField("float 값", floatValue);

        // color field
        colorValue = EditorGUILayout.ColorField("color 값", colorValue);

        // gradient field
        gradientValue = EditorGUILayout.GradientField("gradient 값", gradientValue);

        // vector3 field
        vector3Value = EditorGUILayout.Vector3Field("vector3 값", vector3Value);

        // vector3Int field
        vector3IntValue = EditorGUILayout.Vector3IntField("vector3Int 값", vector3IntValue);

        //rect field
        rectValue = EditorGUILayout.RectField("rect 값", rectValue);

        // object field
        objectValue = EditorGUILayout.ObjectField("obect 값", objectValue, typeof(UnityEngine.Object), false);

        // password field
        passwordValue = EditorGUILayout.PasswordField("password 값", passwordValue);

        // tag 값
        tagValue = EditorGUILayout.TagField("tag 값", tagValue);

        EditorGUILayout.Space(15);

        // enum type field
        enumValue = (UnityEngine.ParticleSystemCollisionType)EditorGUILayout.EnumFlagsField("enum 값", enumValue);

        // slider
        floatValue = EditorGUILayout.Slider("slider", floatValue, 0, 100);

        // help box
        EditorGUILayout.HelpBox("Help box", MessageType.Error);

        // toggle
        toggleValue = EditorGUILayout.Toggle("toggle 값", toggleValue);

        // 줄 긋기
        EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);

        #endregion


        #region ===:: GUILayout ::===

        // toolbar
        // https://lunchballer.com/archives/561
        selectionValue = GUILayout.Toolbar(selectionValue, stringArr);

        GUILayout.Space(15);

        // selection grid
        selectionValue = GUILayout.SelectionGrid(selectionValue, stringArr, 2);

        // box (e.g. texture)
        // https://github.com/halak/unity-editor-icons
        GUILayout.Box(EditorGUIUtility.IconContent("Animation.Record"));
        GUILayout.Box(EditorGUIUtility.IconContent("animationvisibilitytoggleon"));
        GUILayout.Box(EditorGUIUtility.IconContent("animationvisibilitytoggleon@2x"));

        #endregion

    }

    #endregion
}
