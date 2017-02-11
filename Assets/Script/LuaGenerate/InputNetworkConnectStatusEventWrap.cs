﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class InputNetworkConnectStatusEventWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(InputNetworkConnectStatusEvent), typeof(IInputEventBase));
		L.RegFunction("New", _CreateInputNetworkConnectStatusEvent);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("m_status", get_m_status, set_m_status);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateInputNetworkConnectStatusEvent(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				InputNetworkConnectStatusEvent obj = new InputNetworkConnectStatusEvent();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(NetworkState)))
			{
				NetworkState arg0 = (NetworkState)ToLua.CheckObject(L, 1, typeof(NetworkState));
				InputNetworkConnectStatusEvent obj = new InputNetworkConnectStatusEvent(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: InputNetworkConnectStatusEvent.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m_status(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			InputNetworkConnectStatusEvent obj = (InputNetworkConnectStatusEvent)o;
			NetworkState ret = obj.m_status;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_status on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m_status(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			InputNetworkConnectStatusEvent obj = (InputNetworkConnectStatusEvent)o;
			NetworkState arg0 = (NetworkState)ToLua.CheckObject(L, 2, typeof(NetworkState));
			obj.m_status = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_status on a nil value" : e.Message);
		}
	}
}
