﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ZConstant
{

    /// <summary>
    /// 碰到障碍物减分
    /// </summary>
    public const int BarrierScore = -1;
    /// <summary>
    /// 金币得分
    /// </summary>
    public const int IconScore = 1;
    /// <summary>
    /// hand得分
    /// </summary>
    public const int HandScore = 2;
    /// <summary>
    /// 摧毁障碍墙得分
    /// </summary>
    public const int DestroyWallScore = 3;
    /// <summary>
    /// 碰到墙得分
    /// </summary>
    public const int DotnDestroyWallScore = -3;
    /// <summary>
    /// 保持姿势时间
    /// </summary>
    public const float HoldTime = 3;





















    /*---------------------------------------------------------------------------*/



    /// <summary>
    /// 第一个进入房间的玩家将在25s后创建房间
    /// </summary>
    public const float WaitToCreateRoomTime = 25;
    /// <summary>
    /// 创建房间后将在10s后关闭房间加入权限
    /// </summary>
    public const float WaitToTurnOffRoomPerissionTime = 10;
    /// <summary>
    /// 全部扫秒完maker，将在3s后开启minigame
    /// </summary>
    public const float WaitToPlayMiniGameTime = 3;

    public const string Event__Capture__ = "event_capture";
    public const string Event__MiniGame__ = "event_minigame";
    public const string Event__ModelShow__ = "event_modelshow";
    public const string Event__Rotate__ = "event_rotate";

    public const string DefaultDir = "lgu";

    public static string DefaultScheme = "ws";
    public static string ReplaceScheme = "http";


    #region ui_name - bundle

    public const string First = "1st";
    public const string FirstPress = "1st_press";

    public const string Second = "2nd";
    public const string SecondPress = "2nd_press";

    public const string Third = "3rd";
    public const string ThirdPress = "3rd_press";

    public const string Back = "back";

    public const string Bg1 = "bg1";
    public const string Bg2 = "bg2";

    public const string Logo = "logo";

    public const string Minigame = "minigame";
    public const string MinigamePress = "minigame_press";

    public const string Model = "model";
    public const string ModelPress = "model_press";

    public const string Photo = "photo";
    public const string PhotoPress = "photo_press";

    public const string Rotate = "rotate";
    public const string RotatePress = "rotate_press";

    public const string TouchScreen = "touchscreen";

    #endregion
}
