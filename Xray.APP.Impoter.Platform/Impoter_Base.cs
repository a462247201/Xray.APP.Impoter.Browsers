﻿using OfficeOpenXml;
using System;
using System.Collections.Generic;
using Xray.APP.Impoter.Interfaces;

namespace Xray.APP.Impoter.Platform
{
    /// <summary>
    /// 平台操作抽象基类
    /// </summary>
    public abstract class Impoter_Base : IMusicPlatform
    {
        static Impoter_Base()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }
        public ILoginInfo logininfo { get;  set; }
        public IUserInfo userinfo { get;  set; }

        public abstract void AddMusicToList(params object[] parms);
        public abstract void CreateMusicList(params object[] parms);
        public abstract void GetUserInfo();

        public virtual void Login()
        {
            throw new NotImplementedException();
        }

        public virtual void OutPutMusicListToExcel()
        {
            throw new NotImplementedException();
        }

        public abstract List<IMusicInfo> SearchMusic(params object[] parms);
        public abstract List<IMusicInfo> SearchMusic_Suggest(params object[] parms);
    }
}
