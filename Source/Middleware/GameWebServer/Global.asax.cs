﻿using System;
using ZyGames.Framework.Common.Log;
using ZyGames.Framework.Game.Runtime;
using ZyGames.Framework.Script;

namespace GameWebServer
{
    public class Global : System.Web.HttpApplication
    {
        private dynamic _instance;

        protected void Application_Start(object sender, EventArgs e)
        {
            try
            {
                var setting = new EnvironmentSetting();
                GameEnvironment.Start(setting);
                if (ScriptEngines.RunMainClass(out _instance))
                {
                    _instance.Start();
                }
            }
            catch (Exception ex)
            {
                TraceLog.WriteError("App star error:{0}", ex);
            }
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {
            _instance.Stop();
        }
    }
}